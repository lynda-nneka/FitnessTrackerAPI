using System;
using FitnessTracker.Bll.Models;
using FitnessTracker.Bll.Repository;
using FitnessTracker.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Bll.Implementations
{
    public class WorkOutHistoryRepository : IWorkOutHistoryRepository
    {
        private readonly FitnessTrackerDbContext _context;
        public WorkOutHistoryRepository(FitnessTrackerDbContext dbContext)
        {
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

       
        public async Task<IEnumerable<WorkOutExercise>> GetWorkOutHistoryAsync()
        {
            return await _context.WorkOutExercise.OrderBy(a => a.Id).ToListAsync();
        }

        public async Task<bool> UserExistAsync(int userId)
        {
            return await _context.Users.AnyAsync(u => u.Id == userId);
        }


        public async Task<IEnumerable<WorkOutExerciseDto>> GetUserWorkOutHistoryAsync(int userId)
        {

            var workoutHistory = _context.WorkOutExercise.Where(ua => ua.Id== userId);
            return workoutHistory.Select(x => new WorkOutExerciseDto()
            {
                ExerciseId = x.ExerciseId,
                WorkOutId = x.WorkOutId,
                Intensitylevel = x.Intensitylevel,
                Duration = x.Duration,
                Sets = x.Sets,
                Reps = x.Reps,
                CreatedAt = x.CreatedAt 
            });

        }

        public async Task<WorkOutExercise?> GetWorkOutsAsync(int workoutExerciseId)
        {
            return await _context.WorkOutExercise.Where(a => a.Id == workoutExerciseId).FirstOrDefaultAsync();
        }

        public async Task<WorkOutExercise> AddAsync(WorkOutExercise workOutExercise)
        {
            await _context.WorkOutExercise.AddAsync(workOutExercise);
            await SaveChangesAsync();
            return workOutExercise;

        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void DeleteWorkOutExercise(WorkOutExercise workOutExercise)
        {
            _context.WorkOutExercise.Remove(workOutExercise);
        }
    }
}

