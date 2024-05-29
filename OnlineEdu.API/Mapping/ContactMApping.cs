using AutoMapper;
using OnlineEdu.DTO.DTOs.ContactDtos;
using OnlineEdu.Entity.Entity;

namespace OnlineEdu.API.Mapping
{
    public class ContactMApping:Profile
    {
        public ContactMApping()
        {
            CreateMap<CreateContactDto,Contact>().ReverseMap();
            CreateMap<UpdateContactDto,Contact>().ReverseMap();
        }

    }
}
