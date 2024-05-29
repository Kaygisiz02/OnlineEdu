using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.MessageDtos;
using OnlineEdu.Entity.Entity;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesagesController(IGenericService<Message> _messageService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values=_messageService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value= _messageService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _messageService.TDelete(id);
            return Ok("Mesage Alanı Silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateMessageDto createMessageDto)
        {
            var Value=_mapper.Map<Message>(createMessageDto);
            _messageService.TCreate(Value);
            return Ok("Yeni Mesaj Oluşturuldu.");
        }
        [HttpPut]
        public IActionResult Update(UpdateMessageDto updateMessageDto) 
        {
            var Values=_mapper.Map<Message>(updateMessageDto);
            _messageService.TUpdate(Values);
            return Ok("Mesage Alanı Güncellendi");
        }

    }
}
