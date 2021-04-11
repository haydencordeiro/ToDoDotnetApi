using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoApi.Models;
using ToDoApi.Services;

namespace ToDoApi.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class ToDoController : ControllerBase
    {
        public IToDoService _toDoService { get; }

        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;

        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            return Ok(_toDoService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_toDoService.GetSingle(id));
        }

    }
}