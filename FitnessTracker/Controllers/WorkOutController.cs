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
    [Route("fitness/workout")]
    public class WorkOutController : Controller
    {
        private readonly IWorkOutRepository _workout;
        private readonly IMapper _mapper;

        public WorkOutController(IWorkOutRepository workOutRepository, IMapper mapper)
        {
            _workout =workOutRepository ?? throw new ArgumentNullException(nameof(workOutRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: /<controller>/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkOutDto>>> GetWorkOuts()
        {
            var workOuts = await _workout.GetWorkOutsAsync();
            return Ok(_mapper.Map<IEnumerable<WorkOutDto>>(workOuts));
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<WorkOutDto>>> GetUserWorkOuts(int userId)
        {

            if (!await _workout.UserExistAsync(userId))
            {
                return NotFound();
            }
            var userWorkOut = await _workout.GetUserWorkOutsAsync(userId);
            if (userWorkOut == null)
            {
                return NotFound();
            }

            return Ok(userWorkOut);
        }

        [HttpPost]
        public async Task<ActionResult<WorkOutDto>> CreateWorkOut(WorkOutDto workOutDto)
        {
            var workOut = _mapper.Map<WorkOut>(workOutDto);
            await _workout.AddAsync(workOut);
            return Ok(workOut);

        }


        [HttpPatch("{workOutId}")]
        public async Task<ActionResult> PartialUpdateWorkOut(int workOutId, JsonPatchDocument<UserWorkOutForUpdateDto> patchDocument)
        {
            var userWorkOut = await _workout.GetWorkOutAsync(workOutId);
            if (userWorkOut == null)
            {
                return NotFound();
            }
            var userWorkOutToPatch = _mapper.Map<UserWorkOutForUpdateDto>(userWorkOut);
            patchDocument.ApplyTo(userWorkOutToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(userWorkOutToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(userWorkOutToPatch, userWorkOut);
            await _workout.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{workOutId}")]
        public async Task<ActionResult> DeleteWorkOut(int workOutId)
        {
            var workOut = await _workout.GetWorkOutAsync(workOutId);
            if (workOut == null)
            {
                return NotFound();
            }
            _workout.DeleteWorkOut(workOut);
            await _workout.SaveChangesAsync();
            return NoContent();
        }


    }
}

