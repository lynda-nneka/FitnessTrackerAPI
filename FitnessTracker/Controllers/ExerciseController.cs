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
    [Route("fitness/exercise")]
    public class ExerciseController : Controller
    {
        private readonly IExerciseRepository _exercise;
        private readonly IMapper _mapper;

        public ExerciseController(IExerciseRepository exerciseRepository, IMapper mapper)
        {
            _exercise = exerciseRepository ?? throw new ArgumentNullException(nameof(exerciseRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExercisesDto>>> GetExercises()
        {
            var exercise = await _exercise.GetExercisesAsync();
            return Ok(_mapper.Map<IEnumerable<ExercisesDto>>(exercise));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExercisesDto>> GetExercise(int id)
        {
            var exercise = await _exercise.GetExerciseAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ExercisesDto>(exercise));

        }

        [HttpPost]
        public async Task<ActionResult<AchievementsDto>> CreateExercise(ExercisesDto exercisesDto)
        {
            var exercise = _mapper.Map<Exercise>(exercisesDto);
            await _exercise.AddAsync(exercise);
            return Ok(exercise);

        }

        [HttpPatch("{exerciseId}")]
        public async Task<ActionResult> PartialUpdateExercise(int exerciseId, JsonPatchDocument<ExerciseForUpdateDto> patchDocument)
        {
            var exercise = await _exercise.GetExerciseAsync(exerciseId);
            if (exercise == null)
            {
                return NotFound();
            }
            var exerciseToPatch = _mapper.Map<ExerciseForUpdateDto>(exercise);
            patchDocument.ApplyTo(exerciseToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(exerciseToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(exerciseToPatch, exercise);
            await _exercise.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{exerciseId}")]
        public async Task<ActionResult> DeleteAchievement(int exerciseId)
        {
            var exercise = await _exercise.GetExerciseAsync(exerciseId);
            if (exercise == null)
            {
                return NotFound();
            }
            _exercise.DeleteExercise(exercise);
            await _exercise.SaveChangesAsync();
            return NoContent();
        }
    }
}

