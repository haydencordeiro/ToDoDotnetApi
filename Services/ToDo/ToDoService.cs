using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ToDoApi.Dtos;
using ToDoApi.Dtos.ToDo;
using ToDoApi.Models;

namespace ToDoApi.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IMapper _mapper;

        public ToDoService(IMapper mapper)
        {
            _mapper = mapper;
        }
        private static List<ToDo> todos = new List<ToDo>{
            new ToDo{id=1},
            new ToDo{id=2}
        };
        public async Task<List<GetToDoDto>> GetAll()
        {
            return (todos.Select(c => _mapper.Map<GetToDoDto>(c)).ToList());
        }

        public async Task<GetToDoDto> GetSingle(int id)
        {
            ToDo temp = todos.SingleOrDefault(c => c.id == id);

            return (_mapper.Map<GetToDoDto>(temp));
        }
        public async Task<List<GetToDoDto>> AddToDo(AddToDoDto todo)
        {
            ToDo temp = _mapper.Map<ToDo>(todo);
            temp.id = todos.Count + 1;
            todos.Add(temp);
            return (todos.Select(c => _mapper.Map<GetToDoDto>(c)).ToList());

        }
    }
}