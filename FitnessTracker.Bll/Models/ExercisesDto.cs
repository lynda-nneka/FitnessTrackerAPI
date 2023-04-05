using System;
using System.ComponentModel.DataAnnotations;
using FitnessTracker.DAL.Enums;

namespace FitnessTracker.Bll.Models
{
    public class ExercisesDto
    {
        
        [Required(ErrorMessage = "Provide the name value")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(200)]
        public string Description { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
    }
}

