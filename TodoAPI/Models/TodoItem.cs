namespace TodoAPI.Models
{
    public class TodoItem
    {
        new TodoItem { Id = 5, Name = "Quiz #2", IsComplete = false }
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
