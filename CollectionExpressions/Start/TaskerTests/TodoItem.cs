namespace TaskerTests
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string? TaskName { get; set; }
        public TimeSpan Duration { get; set; }
        public CategoryType Type { get; set; }
    }

    public enum CategoryType
    {
        Work,
        Home,
        Hobby
    }
}
