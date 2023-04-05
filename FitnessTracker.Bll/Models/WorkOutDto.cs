using System;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.Models
{
    public class WorkOutDto
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal LiveWeight { get; set; }
    }
}

