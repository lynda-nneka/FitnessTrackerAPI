using System;
using FitnessTracker.DAL.Entities;
using FitnessTracker.DAL.Enums;

namespace FitnessTracker.Bll.Models
{
    public class WorkOutExerciseDto
    {
        
        public int WorkOutId { get; set; }
        public int ExerciseId { get; set; }
        public IntensityLevel Intensitylevel { get; set; }
        public int Duration { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
       public DateTime CreatedAt { get; set; }
       
    }
}

