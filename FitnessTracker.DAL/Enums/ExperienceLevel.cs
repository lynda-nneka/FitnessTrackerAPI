using System;
namespace FitnessTracker.DAL.Enums
{
    public enum ExperienceLevel
    {
        Beginner = 1, Intermediate, Pro

    }

    public static class ExperienceLevelExtension
    {
        public static string? GetStringValue(this ExperienceLevel experience)
        {
            return experience switch
            {
                ExperienceLevel.Beginner => "Beginner",
                ExperienceLevel.Intermediate => "Intermediate",
                ExperienceLevel.Pro => "Pro",
                _ => null
            };
        }
    }
}

