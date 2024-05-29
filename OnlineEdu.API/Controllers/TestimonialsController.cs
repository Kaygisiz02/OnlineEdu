using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.TestimonialDtos;
using OnlineEdu.Entity.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> _testimonialService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value=_testimonialService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var values=_testimonialService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _testimonialService.TDelete(id);
            return Ok("Refarans Alanı Silindi.");
        }
        [HttpPost]
        public IActionResult Create(CreateTestimonialDto createTestimonialDto)
        {
            var Value = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.TCreate(Value);
            return Ok("Yeni Refarans Alanı Eklendi.");
        }
        [HttpPut]
        public IActionResult Update(UpdateTestimonialDto updateTestimonialDto)
        {
            var Values=_mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TUpdate(Values);
            return Ok("Refarans Alanı Güncellendi.");
        }
    }
}
