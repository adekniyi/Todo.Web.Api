using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWebApi.Context;

namespace TodoWebApi.Controllers
{


    [ApiController]
    [Route("api/testdatabase")]
    public class DummyController : ControllerBase
    {

        private readonly TodoInfoContext _ctx;

        public DummyController(TodoInfoContext ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }

        [HttpGet]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
 
    }
}
