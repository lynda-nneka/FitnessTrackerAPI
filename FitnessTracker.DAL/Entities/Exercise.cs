using System;
using FitnessTracker.DAL.Enums;

namespace FitnessTracker.DAL.Entities
{
    public class Exercise : BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}

