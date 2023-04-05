using System;
using AutoMapper;
using FitnessTracker.Bll.Models;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.MappingProfiles
{
    public class AchievementProfile : Profile
    {
        public AchievementProfile()
        {
            CreateMap<Achievement, AchievementsDto>();
            CreateMap<AchievementsDto, Achievement>();
            CreateMap<AchievementForUpdateDto, Achievement>();
            CreateMap<Achievement,AchievementForUpdateDto>();

        }
    }
}

