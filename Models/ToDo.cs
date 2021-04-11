namespace ToDoApi.Models
{
    public class ToDo
    {
        public int id { get; set; } = 0;
        public string task { get; set; } = "";
        public bool completed { get; set; } = false;
    }
}