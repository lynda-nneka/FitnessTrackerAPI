using System;
using FitnessTracker.DAL.Enums;

namespace FitnessTracker.DAL.Entities
{
    public class UserGoal : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public GoalType GoalType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TargetWeight { get; set; }
        public Status Status { get; set; }
    }
}

