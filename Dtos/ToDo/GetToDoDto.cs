namespace ToDoApi.Dtos.ToDo
{
    public class GetToDoDto
    {
        public int id { get; set; } = 0;
        public string task { get; set; } = "";
        public bool completed { get; set; } = false;
    }
}