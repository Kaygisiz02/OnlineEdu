using AutoMapper;
using OnlineEdu.DTO.DTOs.BlogCategoryDtos;
using OnlineEdu.Entity.Entity;

namespace OnlineEdu.API.Mapping
{
    public class BlogCategoryMapping:Profile
    {
        public BlogCategoryMapping()
        {
            CreateMap<CreateBlogCategoryDto, BlogCategory>();
            CreateMap<UpdateBlogCategoryDto, BlogCategory>();
            CreateMap<ResultBlogCategoryDto, BlogCategory>();
        }
    }
}
