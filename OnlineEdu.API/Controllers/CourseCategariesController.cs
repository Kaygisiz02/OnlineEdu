using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseCategoryDtos;
using OnlineEdu.Entity.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategariesController(IGenericService<CourseCategory> _courseCategoryService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values=_courseCategoryService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value=_courseCategoryService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseCategoryService.TDelete(id);
            return Ok("Kurs Kategorisi Silindi.");
        }
        [HttpPost]
        public IActionResult Create(CreateCourseCategoryDto createcourseCategoryDto)
        {
            var Value=_mapper.Map<CourseCategory>(createcourseCategoryDto);
            _courseCategoryService.TCreate(Value);
            return Ok("Yeni Kurs Kategorisi oluşturuldu.");
        }
        [HttpPut]
        public IActionResult Update(UpdateCourseCategoryDto updatecourseCategoryDto)
        {
            var Values=_mapper.Map<CourseCategory>(updatecourseCategoryDto);
            _courseCategoryService.TUpdate(Values);
            return Ok("Yeni Kurs Kategorisi Güncellendi.");
        }
    }
}
