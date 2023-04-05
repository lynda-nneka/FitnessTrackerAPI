﻿using System;
namespace FitnessTracker.DAL.Entities
{
    public class UserAchievement : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int AchievementId { get; set; }
        public  virtual Achievement Achievement { get; set; }
        public DateTime Date { get; set; }
    }
}

