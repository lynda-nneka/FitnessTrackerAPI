using System;
using FitnessTracker.Bll.Models;
using FitnessTracker.Bll.Repository;
using FitnessTracker.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Bll.Implementations
{
    public class AchievementInfoRepository : IAchievmentInfoRepository
    {
        private readonly FitnessTrackerDbContext _context;
        public AchievementInfoRepository(FitnessTrackerDbContext dbContext)
        {
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Achievement> AddAsync(Achievement achievement)
        {
            await _context.Achievement.AddAsync(achievement);
            await SaveChangesAsync();
            return achievement;
           
        }

        public void DeleteAchievement(Achievement achievement)
        {
            _context.Achievement.Remove(achievement);
        }

        public async Task<Achievement?> GetAchievementAsync(int achievementId)
        {
            return await _context.Achievement.Where(a => a.Id == achievementId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Achievement>> GetAchievementsAsync()
        {
            return await _context.Achievement.OrderBy(a => a.Name).ToListAsync();
        }

        public async Task<UserAchievement?> GetUserAchievementAsync(int userId)
        {
           
            return await _context.UserAchievements.Where(u => u.UserId == userId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AchievementsDto>> GetUserAchievementsAsync(int userId)
        {

            var userArchievement = _context.UserAchievements.Where(ua => ua.UserId == userId); 
            return userArchievement.Select(x => new AchievementsDto()
            {
                Name = x.Achievement.Name,
                Description = x.Achievement.Description
            });
            
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public async Task<bool>UserExistAsync(int userId)
        {
            return await _context.Users.AnyAsync(u => u.Id == userId);
        }
        //public async Task<bool>achievementExistAsync(int achievementId)
        //{
        //    return await _context.Achievement.AnyAsync(a => a.Id == achievementId);
        //}
    
    }
}

