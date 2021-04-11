using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApi.Dtos;
using ToDoApi.Dtos.ToDo;
using ToDoApi.Models;

namespace ToDoApi.Services
{
    public interface IToDoService
    {
        public Task<List<GetToDoDto>> GetAll();
        public Task<GetToDoDto> GetSingle(int id);
        public Task<List<GetToDoDto>> AddToDo(AddToDoDto todo);




    }
}