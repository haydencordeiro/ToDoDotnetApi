using System.Collections.Generic;
using ToDoApi.Models;

namespace ToDoApi.Services
{
    public interface IToDoService
    {
        public List<ToDo> GetAll();
        public ToDo GetSingle(int id);

    }
}