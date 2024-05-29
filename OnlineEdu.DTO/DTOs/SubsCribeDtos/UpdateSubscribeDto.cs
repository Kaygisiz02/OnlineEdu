using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTOs.SubsCribeDtos
{
    public class UpdateSubscribeDto
    {
        public int SubscribeId { get; set; }
        public string Email { get; set; }
        public string IsActive { get; set; }
    }
}
