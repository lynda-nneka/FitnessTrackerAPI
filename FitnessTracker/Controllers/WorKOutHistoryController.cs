using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FitnessTracker.Bll.Models;
using FitnessTracker.Bll.Repository;
using FitnessTracker.DAL.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessTracker.Controllers
{
    [ApiController]
    [Route("fitness/workouthistory")]
    public class WorkOutHistoryController : Controller
    {
        private readonly IWorkOutHistoryRepository _workoutHistory;
        private readonly IMapper _mapper;

        public WorkOutHistoryController(IWorkOutHistoryRepository workOutHistoryRepository, IMapper mapper)
        {
            _workoutHistory = workOutHistoryRepository ?? throw new ArgumentNullException(nameof(workOutHistoryRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: /<controller>/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkOutExerciseDto>>> GetWorkOuts()
        {
            var workOuts = await _workoutHistory.GetWorkOutHistoryAsync();
            return Ok(_mapper.Map<IEnumerable<WorkOutExerciseDto>>(workOuts));
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<WorkOutExercise>>> GetUserWorkOutHistory(int userId)
        {
            if (!await _workoutHistory.UserExistAsync(userId))
            {
                return NotFound();
            }
            var userWorkOutHistory = await _workoutHistory.GetUserWorkOutHistoryAsync(userId);
            if (userWorkOutHistory == null)
            {
                return NotFound();
            }

            return Ok(userWorkOutHistory);
        }

        [HttpPost]
        public async Task<ActionResult<WorkOutExerciseDto>> CreateUserWorkoutHistory(WorkOutExerciseDto workOutExerciseDto)
        {
            var workOutHistory = _mapper.Map<WorkOutExercise>(workOutExerciseDto);
            await _workoutHistory.AddAsync(workOutHistory);
            return Ok(workOutHistory);

        }

        [HttpPatch("{workOutExerciseId}")]
        public async Task<ActionResult> PartialUpdateWorkOutExercise(int workOutExerciseId, JsonPatchDocument<WorkOutExerciseForUpdateDto> patchDocument)
        {
            var workoutHistory = await _workoutHistory.GetWorkOutsAsync(workOutExerciseId);
            if (workoutHistory == null)
            {
                return NotFound();
            }
            var workOutToPatch = _mapper.Map<WorkOutExerciseForUpdateDto>(workoutHistory);
            patchDocument.ApplyTo(workOutToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(workOutToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(workOutToPatch, workoutHistory);
            await _workoutHistory.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{workOutExerciseId}")]
        public async Task<ActionResult> DeleteAchievement(int workOutExerciseId)
        {
            var workOutHistory = await _workoutHistory.GetWorkOutsAsync(workOutExerciseId);
            if (workOutHistory == null)
            {
                return NotFound();
            }
            _workoutHistory.DeleteWorkOutExercise(workOutHistory);
            await _workoutHistory.SaveChangesAsync();
            return NoContent();
        }
    }
}

