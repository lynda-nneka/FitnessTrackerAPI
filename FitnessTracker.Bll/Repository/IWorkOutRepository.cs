using System;
using FitnessTracker.Bll.Models;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.Repository
{
    public interface IWorkOutRepository
    {
        Task<WorkOut>AddAsync(WorkOut workOut);
        //Task<WorkOut> GetUserWorkOutAsync(int userId);
       
        Task<IEnumerable<WorkOut>> GetWorkOutsAsync();
        Task<bool>UserExistAsync(int userId);
        Task<bool>SaveChangesAsync();
        void DeleteWorkOut(WorkOut workOut);
        Task <IEnumerable<WorkOut>> GetUserWorkOutsAsync(int workOutId);
        Task<WorkOut?> GetWorkOutAsync(int workOutId);
    }
}

