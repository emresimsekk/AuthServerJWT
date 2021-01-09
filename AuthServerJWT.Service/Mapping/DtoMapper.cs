using AuthServerJWT.Core.Dtos;
using AuthServerJWT.Core.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServerJWT.Service.Mapping
{
    class DtoMapper:Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }

    }
}
