using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseCategoryDtos;
using OnlineEdu.DTO.DTOs.CourseDtos;
using OnlineEdu.Entity.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(IGenericService<Course> _courseService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _courseService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseService.TDelete(id);
            return Ok("Kurs Kategorisi Silindi.");
        }
        [HttpPost]
        public IActionResult Create(CreateCourseDto createcourseDto)
        {
            var Value = _mapper.Map<Course>(createcourseDto);
            _courseService.TCreate(Value);
            return Ok("Yeni Kurs oluşturuldu.");
        }
        [HttpPut]
        public IActionResult Update(UpdateCourseDto updatecourseDto)
        {
            var Values = _mapper.Map<Course>(updatecourseDto);
            _courseService.TUpdate(Values);
            return Ok("Yeni Kurs Güncellendi.");
        }
    }
}
