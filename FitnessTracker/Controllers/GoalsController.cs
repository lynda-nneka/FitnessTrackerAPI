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
    [Route("fitness/userGoal")]
    public class GoalsController : Controller
    {

        private readonly IUserGoalRepository _userGoal;
        private readonly IMapper _mapper;

        public GoalsController(IUserGoalRepository userGoalRepository, IMapper mapper)
        {
            _userGoal = userGoalRepository ?? throw new ArgumentNullException(nameof(userGoalRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: /<controller>/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserGoalsDto>>> GetUserGoals()
        {

            var userGoal = await _userGoal.GetUserGoalsAsync();
            return Ok(_mapper.Map<IEnumerable<UserGoalsDto>>(userGoal));

        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<UserGoalsDto>> GetUserGoal(int userId)
        {
            if (!await _userGoal.UserExistAsync(userId))
            {
                return NotFound();
            }
            var userGoal = await _userGoal.GetUserGoalAsync(userId);
            if (userGoal == null)
            {
                return NotFound();
            }

            return Ok(userGoal);
        }

        [HttpPost]
        public async Task<ActionResult<UserGoalsDto>> CreateGoal(UserGoalsDto userGoalDto)
        {
            var userGoal = _mapper.Map<UserGoal>(userGoalDto);
            await _userGoal.AddAsync(userGoal);
            return Ok(userGoal);

        }

        [HttpPatch("{goalId}")]
        public async Task<ActionResult> PartialUpdateUserGoal(int goalId, JsonPatchDocument<UserGoalForUpdateDto> patchDocument)
        {
            var userGoal = await _userGoal.GetUserGoalAsync(goalId);
            if (userGoal == null)
            {
                return NotFound();
            }
            var userGoalToPatch = _mapper.Map<UserGoalForUpdateDto>(userGoal);
            patchDocument.ApplyTo(userGoalToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(userGoalToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(userGoalToPatch, userGoal);
            await _userGoal.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{goalId}")]
        public async Task<ActionResult> DeleteGoal(int goalId)
        {
            var userGoal = await _userGoal.GetUserGoalAsync(goalId);
            if (userGoal == null)
            {
                return NotFound();
            }
            _userGoal.DeleteUserGoal(userGoal);
            await _userGoal.SaveChangesAsync();
            return NoContent();
        }
    }
}

