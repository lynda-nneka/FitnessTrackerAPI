using System;
using AutoMapper;
using FitnessTracker.Bll.Models;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.MappingProfiles
{
    public class WorkOutHistoryProfile : Profile
    {
        public WorkOutHistoryProfile()
        {
            CreateMap<WorkOutExercise, WorkOutExerciseDto>();
            CreateMap<WorkOutExerciseDto, WorkOutExercise>();
            CreateMap<WorkOutExerciseForUpdateDto, WorkOutExercise>();
            CreateMap<WorkOutExercise, WorkOutExerciseForUpdateDto>();
        }
        
    }
}

