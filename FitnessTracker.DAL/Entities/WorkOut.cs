using System;
using FitnessTracker.DAL.Enums;

namespace FitnessTracker.DAL.Entities
{
    public class WorkOut : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public decimal LiveWeight { get; set; }
        
    }
}

