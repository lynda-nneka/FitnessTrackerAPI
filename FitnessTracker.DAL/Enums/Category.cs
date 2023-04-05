using System;
namespace FitnessTracker.DAL.Enums
{
    public enum Category
    {
        Cardio = 1, Strength, Stretches
    }

    public static class CategoriesExtension
    {
        public static string? GetStringValue(this Category workOutType)
        {
            return workOutType switch
            {
                Category.Cardio => "Cardio",
                Category.Strength => "Strength",
                Category.Stretches => "Stretches",
                _ => null
            };
        }
    }
}

