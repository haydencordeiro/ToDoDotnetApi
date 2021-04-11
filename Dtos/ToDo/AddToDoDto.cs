namespace ToDoApi.Dtos
{
    public class AddToDoDto
    {

        public string task { get; set; } = "";
        public bool completed { get; set; } = false;
    }
}