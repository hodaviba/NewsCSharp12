
using TaskerTests;

var taskRepository = new TaskRepository();

var homeTasks = taskRepository.Tasks.Where(t => t.Type == CategoryType.Home)
    .ToList();

var workTasks = taskRepository.Tasks.Where(t => t.Type == CategoryType.Work)
    .ToList();

var hobbyTasks = taskRepository.Tasks.Where(t => t.Type == CategoryType.Hobby)
    .ToList();


//CALCULATOR SECTION

var calculator = new TimeCalculator();

var totalHomeTasksDuration = calculator.ComputeTodoTime(
[
    new (1,1,1),
    new (2,2,2),
    new (3,3,3),
    new (4,4,4),
    new (5,5,5),
]);


Console.WriteLine($"Estimated Duration: {totalHomeTasksDuration.Hours}:{totalHomeTasksDuration.Minutes}:{totalHomeTasksDuration.Seconds}");

List<TodoItem> allTasks = [.. homeTasks, .. workTasks, .. hobbyTasks];

var totalAllTasksDuration = calculator.ComputeTodoTime(allTasks.Select(t => t.Duration).ToList());

Console.WriteLine($"Total Duration: {totalAllTasksDuration.Hours}:{totalAllTasksDuration.Minutes}:{totalAllTasksDuration.Seconds}");
