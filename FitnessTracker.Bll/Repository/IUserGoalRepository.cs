using System;
using FitnessTracker.Bll.Models;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.Repository
{
    public interface IUserGoalRepository
    {
        Task<IEnumerable<UserGoal>> GetUserGoalsAsync();
        Task<bool> UserExistAsync(int userId);
        Task<UserGoal> GetUserGoalAsync(int userGoalId);
        Task<UserGoal> AddAsync(UserGoal userGoal);
        Task<bool> SaveChangesAsync();
        void DeleteUserGoal(UserGoal userGoal);
    }
}

