using System;
using FitnessTracker.Bll.Models;
using FitnessTracker.Bll.Repository;
using FitnessTracker.DAL.Entities;
using FitnessTracker.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Bll.Implementations
{
    public class UserGoalRepository : IUserGoalRepository
    {
        private readonly FitnessTrackerDbContext _context;
        public UserGoalRepository(FitnessTrackerDbContext dbContext)
        {
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<UserGoal> AddAsync(UserGoal userGoal)
        {
            await _context.UserGoal.AddAsync(userGoal);
            await SaveChangesAsync();
            return userGoal;
        }

        public void DeleteUserGoal(UserGoal userGoal)
        {
            _context.UserGoal.Remove(userGoal);
        }

        public async Task<UserGoal> GetUserGoalAsync(int userGoalId)
        {
            return await _context.UserGoal.Where(u => u.UserId == userGoalId).FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<UserGoal>> GetUserGoalsAsync()
        {
            return await _context.UserGoal.OrderBy(a => a.Id).ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public async Task<bool> UserExistAsync(int userId)
        {
            return await _context.Users.AnyAsync(u => u.Id == userId);
        }
    }
}

