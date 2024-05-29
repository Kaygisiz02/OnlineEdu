using AutoMapper;
using OnlineEdu.DTO.DTOs.AboutDtos;
using OnlineEdu.DTO.DTOs.SubsCribeDtos;
using OnlineEdu.Entity.Entity;

namespace OnlineEdu.API.Mapping
{
    public class SubscribeMapping:Profile
    {
        public SubscribeMapping()
        {
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<UpdateSubscribeDto, Subscribe>().ReverseMap();
        }
    }
}
