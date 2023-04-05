using System;
using AutoMapper;
using FitnessTracker.Bll.Models;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.MappingProfiles
{
    public class WorkOutProfile : Profile
    {
        public WorkOutProfile()
        {
            CreateMap<WorkOut, WorkOutDto>();
            CreateMap<WorkOutDto, WorkOut>();
            CreateMap<UserWorkOutForUpdateDto, WorkOut>();
            CreateMap<WorkOut, UserWorkOutForUpdateDto>();
        }
        
    }
}

