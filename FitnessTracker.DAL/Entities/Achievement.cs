using System;
namespace FitnessTracker.DAL.Entities
{
    public class Achievement : BaseEntity
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
    }
}

