using wholesale_store.Models.Entities;
using wholesale_store.Servicess.Repositories;


namespace wholesale_store.Servicess.Servicess

{
    public class TaskService :ITasksRepository
    {
        public List<Tasks> AllTasks() 
        {
            var allTasks = new List<Tasks>();

            var task1 = new Tasks{
                Id = "001",
                Name = "GetShot",
                Description = "TestTask",
                Status = "Gone",
                CreatedAt = DateTime.Now
            };
            allTasks.Add(task1);

            var todo1 = new Tasks
            {
                Id = "002",
                Name = "Come Home",
                Description = "Test Task2",
                Status = "Done",
                CreatedAt = DateTime.Now
            };
            allTasks.Add(todo1);


            return allTasks; 
        }
    }
}
