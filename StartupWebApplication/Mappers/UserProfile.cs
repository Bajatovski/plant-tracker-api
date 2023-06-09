﻿using AutoMapper;
using DataTransferLayer.DTO;
using PlantTrackerAPI.DataTransferLayer.DTO;
using PlantTrackerAPI.DomainModel;
using PlantTrackerAPI.Models;
using StartupWebApplication.Models;
using System.Linq;

namespace StartupWebApplication.Mappers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<PlantImageDTO, PlantImageModel>().ReverseMap();
            CreateMap<PlantNeedDTO, PlantNeedModel>().ReverseMap();
            CreateMap<UserDTO, UserModel>().ReverseMap();
            CreateMap<PlantDTO, PlantModel>().ReverseMap();
            CreateMap<PlantDTO, PlantAddModel>().ReverseMap();
            CreateMap<RegisterDTO, UserModel>().ReverseMap();
            CreateMap<LoginDTO, RequestLoginModel>().ReverseMap();
            CreateMap<UserDTO, ResponseLoginModel>().ReverseMap();
            CreateMap<ForgotPasswordRequestDTO, ForgotPasswordModel>().ReverseMap();
            CreateMap<LoginDTO, RequestLoginModel>().ReverseMap();
            CreateMap<RegisterDTO, RegisterModel>().ReverseMap();
            CreateMap<ResetPasswordDto, ResetPasswordModel>().ReverseMap();
            CreateMap<NeedDTO, NeedModel>().ReverseMap();
            CreateMap<MonthDTO, MonthModel>().ReverseMap();
        }
    }
}
