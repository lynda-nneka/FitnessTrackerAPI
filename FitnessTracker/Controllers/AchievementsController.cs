using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using FitnessTracker.Bll.Implementations;
using FitnessTracker.Bll.Models;
using FitnessTracker.Bll.Repository;
using FitnessTracker.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessTracker.Controllers
{
    [ApiController]
    [Route("fitness/achievement")]
    public class AchievementsController : Controller
    {
        private readonly IAchievmentInfoRepository _achievmentInfo;
        private readonly IMapper _mapper;

        public AchievementsController(IAchievmentInfoRepository achievmentInfoRepository, IMapper mapper)
        {
            _achievmentInfo = achievmentInfoRepository ?? throw new ArgumentNullException(nameof(achievmentInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        //GET: /<controller>/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AchievementsDto>>> GetAchievements()
        {
            var achievementEntity = await _achievmentInfo.GetAchievementsAsync();
            //var result = new List<AchievementsDto>();
            //foreach(var achievement in achievementEntity)
            //{
            //    result.Add(new AchievementsDto
            //    {

            //        Name = achievement.Name,
            //        Date = achievement.Date,
            //        Description = achievement.Description

            //    });
            //}
            return Ok(_mapper.Map<IEnumerable<AchievementsDto>>(achievementEntity));


        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AchievementsDto>> GetAchievement(int id)
        {
            var achievement = await _achievmentInfo.GetAchievementAsync(id);
            if (achievement == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<AchievementsDto>(achievement));

        }
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<UserAchievement>>> GetUserAchievements(int userId)
        {
            if (!await _achievmentInfo.UserExistAsync(userId))
            {
                return NotFound();
            }
            var userAchievements = await _achievmentInfo.GetUserAchievementsAsync(userId);
            if (userAchievements == null)
            {
                return NotFound();
            }

            return Ok(userAchievements);
        }
        [HttpPost]
        public async Task<ActionResult<AchievementsDto>> CreateAchievement(AchievementsDto achievementsDto)
        {
            var achievement = _mapper.Map<Achievement>(achievementsDto);
            await _achievmentInfo.AddAsync(achievement);
            return Ok(achievement);

        }
        [HttpPut("{achievementId}")]
        public async Task<ActionResult> UpdateAchievement(int achievementId, AchievementForUpdateDto achievementForUpdateDto)
        {
            //if(!await _achievmentInfo.achievementExistAsync(achievementId))
            //{
            //    return NotFound();
            //}
            var achievement = await _achievmentInfo.GetAchievementAsync(achievementId);
            if (achievement == null)
            {
                return NotFound();
            }
            _mapper.Map(achievementForUpdateDto, achievement);
            await _achievmentInfo.SaveChangesAsync();
            return NoContent();
        }

        [HttpPatch("{achievementId}")]
        public async Task<ActionResult> PartialUpdateAchievement(int achievementId, JsonPatchDocument<AchievementForUpdateDto> patchDocument)
        {
            var achievement = await _achievmentInfo.GetAchievementAsync(achievementId);
            if (achievement == null)
            {
                return NotFound();
            }
            var achievementToPatch = _mapper.Map<AchievementForUpdateDto>(achievement);
            patchDocument.ApplyTo(achievementToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(achievementToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(achievementToPatch, achievement);
            await _achievmentInfo.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{achievementId}")]
        public async Task<ActionResult> DeleteAchievement(int achievementId)
        {
            var achievement = await _achievmentInfo.GetAchievementAsync(achievementId);
            if (achievement == null)
            {
                return NotFound();
            }
            _achievmentInfo.DeleteAchievement(achievement);
            await _achievmentInfo.SaveChangesAsync();
            return NoContent();
        }
    }
}