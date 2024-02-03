using Shared.Model.Tasks;
using Task = Shared.Model.Tasks.Task;

namespace LO.Api.Contracts
{
    public interface ITasksApi
    {
        List<Task> GetTasks();
    }
}
