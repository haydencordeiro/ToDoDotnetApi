using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class ToDoController : ControllerBase
    {
        private static List<ToDo> todos = new List<ToDo>{
            new ToDo{id=1},
            new ToDo{id=2}
        };

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(todos.SingleOrDefault(c => c.id == id));
        }

    }
}