using AutoMapper;
using internetBankingProject.Models;
using InternetBankingProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<AccountRight, AccountRightDto>().ReverseMap();
            CreateMap<AccountRight, CreateAccountRightDto>().ReverseMap();
            CreateMap<DeliveryMode,DeliveryModeDto>().ReverseMap();
            CreateMap<DeliveryMode, CreateDeliveryModeDto>().ReverseMap();
            CreateMap<RetailAccount, RetailAccountDto>().ReverseMap();
            CreateMap<RetailAccount, CreateRetailAccountDto>().ReverseMap();
            CreateMap<RetailUser, RetailUserDto>().ReverseMap();
            CreateMap<RetailUser, CreateRetailAccountDto>().ReverseMap();
        }
    }
}
