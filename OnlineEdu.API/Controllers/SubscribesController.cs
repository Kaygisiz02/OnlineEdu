using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.SubsCribeDtos;
using OnlineEdu.Entity.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribesController(IGenericService<Subscribe> _subscribeService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = _subscribeService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var values=_subscribeService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subscribeService.TDelete(id);
            return Ok("Abone Silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateSubscribeDto createSubscribeDto)
        {
            var Value=_mapper.Map<Subscribe>(createSubscribeDto);
            _subscribeService.TCreate(Value);
            return Ok("Yeni Bir Abone Eklendi");
        }
        [HttpPut]
        public IActionResult Update(UpdateSubscribeDto updateSubscribeDto)
        {
            var Value=_mapper.Map<Subscribe>(updateSubscribeDto);
            _subscribeService.TUpdate(Value);
            return Ok("Yeni Abone Güncellendi.");
        }
    }
}
