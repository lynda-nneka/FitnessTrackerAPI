using System;
using FitnessTracker.DAL.Enums;

namespace FitnessTracker.DAL.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int Age{ get; set; }
        public string Gender { get; set; }
        public decimal BMI { get; set; }
        public ExperienceLevel Experiencelevel { get; set; }


    }
}

