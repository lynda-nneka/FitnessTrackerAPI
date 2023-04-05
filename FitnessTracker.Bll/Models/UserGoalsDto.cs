using System;
using FitnessTracker.DAL.Entities;
using FitnessTracker.DAL.Enums;

namespace FitnessTracker.Bll.Models
{
    public class UserGoalsDto
    {
        public int UserId { get; set; }
        public GoalType GoalType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TargetWeight { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

