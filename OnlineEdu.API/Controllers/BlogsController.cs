﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BannerDtos;
using OnlineEdu.DTO.DTOs.BlogDtos;
using OnlineEdu.Entity.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IGenericService<Blog> _blogService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _blogService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            _blogService.TDelete(id);
            return Ok("Blok Alanı Silindi");
        }
        [HttpPost]

        public IActionResult Create(CreateBlogDto createBlogDto)
        {
            var newValue = _mapper.Map<Blog>(createBlogDto);
            _blogService.TCreate(newValue);
            return Ok("Yeni Blok Alanı  Oluşturuldu");
        }
        [HttpPut]
        public IActionResult Update(UpdateBlogDto updateBlogDto)
        {
            var value = _mapper.Map<Blog>(updateBlogDto);
            _blogService.TUpdate(value);
            return Ok("Blok Alanı Güncellendi.");
        }
    }
}
