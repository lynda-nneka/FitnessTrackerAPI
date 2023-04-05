using System;
using FitnessTracker.Bll.Models;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.Repository
{
    public interface IAchievmentInfoRepository
    {
        Task<Achievement> AddAsync(Achievement achievement);
        Task<IEnumerable<Achievement>> GetAchievementsAsync();
        Task<Achievement?> GetAchievementAsync(int achievementId);
        Task<IEnumerable<AchievementsDto>> GetUserAchievementsAsync(int userId);
        Task<UserAchievement?> GetUserAchievementAsync(int userId);
        void DeleteAchievement(Achievement achievement);
        Task<bool> UserExistAsync(int userId);
        Task<bool> SaveChangesAsync();
        //Task<bool> achievementExistAsync(int achievementId);
    }
}

