using AutoMapper;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Service.DTOs;

namespace OnlineMarket.Service.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product,ProductForResultDto>
        }
    }
}
