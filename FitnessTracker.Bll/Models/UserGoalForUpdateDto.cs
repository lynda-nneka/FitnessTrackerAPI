using System;
using FitnessTracker.DAL.Enums;

namespace FitnessTracker.Bll.Models
{
    public class UserGoalForUpdateDto
    {
       
        public GoalType GoalType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TargetWeight { get; set; }
        public Status Status { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

