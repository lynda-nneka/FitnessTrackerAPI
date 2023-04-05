using System;
using FitnessTracker.Bll.Models;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.Repository
{
    public interface IWorkOutHistoryRepository
    {
        //Task<WorkOutExercise>GetUserWorkOutsAsync(int userId);
        Task<IEnumerable<WorkOutExercise>> GetWorkOutHistoryAsync();
        Task<bool> UserExistAsync(int userId);
        Task<IEnumerable<WorkOutExerciseDto>> GetUserWorkOutHistoryAsync(int userId);
        Task<WorkOutExercise> AddAsync(WorkOutExercise workOutExercise);
        void DeleteWorkOutExercise(WorkOutExercise workOutExercise);
        Task<WorkOutExercise?> GetWorkOutsAsync(int workoutExerciseId);
        Task<bool> SaveChangesAsync();
    }
}

