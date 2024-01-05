namespace TaskerTests
{
    public class TaskRepository
    {
        public List<TodoItem> Tasks { get; set; }

        public TaskRepository()
        {
            Tasks =
            [
                new(1, "Demo Task 1", new (1, 0, 0), CategoryType.Work),
                new(2, "Demo Task 2", new (2, 0, 0), CategoryType.Home),
                new(3, "Demo Task 3", new (3, 0, 0), CategoryType.Work),
                new(4, "Demo Task 4", new (4, 0, 0), CategoryType.Hobby),
                new(5, "Demo Task 5", new (5, 0, 0), CategoryType.Work)
            ];
        }

        public void Add(TodoItem task)
        {
            Tasks.Add(task);
        }

        public void Remove(TodoItem task)
        {
            Tasks.Remove(task);
        }

        public TodoItem GetByCategories(CategoryType categoryType) =>
            Tasks.FirstOrDefault(t => t.Type == categoryType);


    }

    public class TimeCalculator
    {
        public TimeSpan ComputeTodoTime(List<TimeSpan> time)
        {
            TimeSpan calculation = TimeSpan.Zero;

            time.ForEach(item => calculation += item);

            return calculation;
        }
    }

}
