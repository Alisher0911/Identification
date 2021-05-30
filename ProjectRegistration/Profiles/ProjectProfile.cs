using System;
using AutoMapper;
using ProjectRegistration.DTOs;
using ProjectRegistration.Models;

namespace ProjectRegistration.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<Project, ProjectDTO>().ReverseMap();
        }
    }
}
