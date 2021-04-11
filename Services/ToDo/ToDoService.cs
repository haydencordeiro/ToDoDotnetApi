using System.Collections.Generic;
using System.Linq;
using ToDoApi.Models;

namespace ToDoApi.Services
{
    public class ToDoService : IToDoService
    {

        private static List<ToDo> todos = new List<ToDo>{
            new ToDo{id=1},
            new ToDo{id=2}
        };
        public List<ToDo> GetAll()
        {
            return (todos);
        }

        public ToDo GetSingle(int id)
        {
            return (todos.SingleOrDefault(c => c.id == id));
        }
    }
}