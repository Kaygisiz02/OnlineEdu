using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.SocialMediaDtos;
using OnlineEdu.Entity.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(IGenericService<SocialMedia> _socialMediaService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value=_socialMediaService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var values=_socialMediaService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _socialMediaService.TDelete(id);
            return Ok("Social Medya Alanı Silindi.");
        }
        [HttpPost]
        public IActionResult Create(CreateSocialMediaDto createSocialMediaDto)
        {
            var Value=_mapper.Map<SocialMedia>(createSocialMediaDto);
            _socialMediaService.TCreate(Value);
            return Ok("Yeni Sosyal Medya Alanı Oluşturuldu.");
        }
        [HttpPut]
        public IActionResult Update(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var Values=_mapper.Map<SocialMedia>(updateSocialMediaDto);
            _socialMediaService.TUpdate(Values);
            return Ok("Yeni Sosyal Medya Alanı Güncellendi.");
        }
    }
}
