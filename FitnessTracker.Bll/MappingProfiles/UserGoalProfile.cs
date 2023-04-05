using System;
using AutoMapper;
using FitnessTracker.Bll.Models;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.MappingProfiles
{
    public class UserGoalProfile : Profile
    {
        public UserGoalProfile()
        {
            CreateMap<UserGoal, UserGoalsDto>();
            CreateMap<UserGoalsDto, UserGoal>();
            CreateMap<UserGoalForUpdateDto, UserGoal>();
            CreateMap<UserGoal, UserGoalForUpdateDto>();
        }
    }
}

