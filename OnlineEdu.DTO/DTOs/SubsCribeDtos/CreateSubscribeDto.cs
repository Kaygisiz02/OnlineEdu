﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTOs.SubsCribeDtos
{
    public class CreateSubscribeDto
    {
        public string Email { get; set; }
        private bool IsActive { get => true; }
    }
}
