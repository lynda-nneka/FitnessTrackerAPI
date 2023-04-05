using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Bll.Models
{
    public class AchievementForUpdateDto
    {

        [Required(ErrorMessage = "Provide the name value")]
        public string Name { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [MaxLength(200)]
        public string Description { get; set; }
    }
}

