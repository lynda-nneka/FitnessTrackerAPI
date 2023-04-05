using System;
using FitnessTracker.Bll.Models;
using FitnessTracker.Bll.Repository;
using FitnessTracker.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Bll.Implementations
{
    public class WorkOutRepository : IWorkOutRepository
    {
        private readonly FitnessTrackerDbContext _context;
        public WorkOutRepository(FitnessTrackerDbContext dbContext)
        {
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }


        public async Task<IEnumerable<WorkOut>> GetWorkOutsAsync()
        {
            return await _context.WorkOut.OrderBy(a => a.Id).ToListAsync();
        }

        public async Task<IEnumerable<WorkOut>> GetUserWorkOutsAsync(int userId)
        {

            var userWorkOut = _context.WorkOut.Where(ua => ua.UserId == userId);
            return userWorkOut.Select(x => new WorkOut()
            {
                UserId = x.UserId,
                Date = x.Date,
                LiveWeight = x.LiveWeight
            });

        }

        public async Task<bool> UserExistAsync(int userId)
        {
            return await _context.Users.AnyAsync(u => u.Id == userId);
        }

        public async Task<WorkOut> AddAsync(WorkOut workOut)
        {
            await _context.WorkOut.AddAsync(workOut);
            await SaveChangesAsync();
            return workOut;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return(await _context.SaveChangesAsync() > 0);
        }

       

        public void DeleteWorkOut(WorkOut workOut)
        {
            _context.WorkOut.Remove(workOut);
        }

        public async Task<WorkOut?> GetWorkOutAsync(int workOutId)
        {
            return await _context.WorkOut.Where(a => a.Id == workOutId).FirstOrDefaultAsync();
        }
    }
}

 