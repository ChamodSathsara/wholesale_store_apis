

using wholesale_store.Models.Entities;

namespace wholesale_store.Servicess.Repositories
{
    public interface ITasksRepository
    {
        public List<Tasks> AllTasks();
    }
}