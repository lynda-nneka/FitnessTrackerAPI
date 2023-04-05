using System;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.Repository
{
    public interface IExerciseRepository
    {
        Task<IEnumerable<Exercise>> GetExercisesAsync();
        Task<Exercise?> GetExerciseAsync(int exerciseId);
        Task<Exercise> AddAsync(Exercise exercise);
        Task<bool> SaveChangesAsync();
        void DeleteExercise(Exercise exercise);
    }
}

