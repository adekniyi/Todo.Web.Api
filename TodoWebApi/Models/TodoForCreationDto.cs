﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoWebApi.Models
{
    public class TodoForCreationDto
    {
        public string todo { get; set; }

        public bool isCompleted { get; set; }
    }
}
