using System;
using AutoMapper;
using FitnessTracker.Bll.Models;
using FitnessTracker.DAL.Entities;

namespace FitnessTracker.Bll.MappingProfiles
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<Exercise, ExercisesDto>();
            CreateMap<ExercisesDto, Exercise>();
            CreateMap<ExerciseForUpdateDto, Exercise>();
            CreateMap<Exercise, ExerciseForUpdateDto>();

        }
    }
}

