using System;
using FitnessTracker.DAL.Enums;

namespace FitnessTracker.DAL.Entities
{
    public class WorkOutExercise : BaseEntity
    {
        public int WorkOutId { get; set; }
        public WorkOut WorkOut { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public IntensityLevel Intensitylevel { get; set; }
        public int Duration { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
    }
}

