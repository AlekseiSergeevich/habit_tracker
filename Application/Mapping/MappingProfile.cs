using System;
using Application.DTO;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Habit, HabitDto>().ReverseMap();
            CreateMap<HabitRecord, HabitRecordDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
