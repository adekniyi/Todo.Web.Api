using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoWebApi.Models
{
    public class TodoDto
    {
        public int id { get; set; }
        public string todo { get; set; }

        public bool isCompleted { get; set; }

    }
}
