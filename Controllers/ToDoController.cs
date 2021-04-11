using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoApi.Dtos;
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
        public async Task<IActionResult> GetAll()
        {

            return Ok(await _toDoService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _toDoService.GetSingle(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddToDo(AddToDoDto todo)
        {


            return Ok(await _toDoService.AddToDo(todo));
        }
    }
}