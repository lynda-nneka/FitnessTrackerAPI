using System;
using FitnessTracker.Bll.Repository;
using FitnessTracker.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Bll.Implementations
{
    public class ExerciseRepository : IExerciseRepository
    {

        private readonly FitnessTrackerDbContext _context;
        public ExerciseRepository(FitnessTrackerDbContext dbContext)
        {
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Exercise>AddAsync(Exercise exercise)
        {
            await _context.Exercise.AddAsync(exercise);
            await SaveChangesAsync();
            return exercise;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public async Task<Exercise?> GetExerciseAsync(int exerciseId)
        {
            return await _context.Exercise.Where(a => a.Id == exerciseId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Exercise>> GetExercisesAsync()
        {
            return await _context.Exercise.OrderBy(a => a.Name).ToListAsync();
        }

        public void DeleteExercise(Exercise exercise)
        {
            _context.Exercise.Remove(exercise);
        }
    }
}

