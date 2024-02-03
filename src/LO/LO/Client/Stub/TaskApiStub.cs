using LO.Api.Contracts;
using Shared.Model.Tasks;
using Task = Shared.Model.Tasks.Task;

namespace LO.Client.Stub
{
    public class TaskApiStub : ITasksApi
    {
        public List<Task> GetTasks()
        {
            return new List<Task>()
            {
                new Task("Frog", "One day's frog", DateTime.Now, false, Importance.AFrog),
                new Task("Laundry", "Do the laundry", DateTime.Now, false, Importance.ItsGottaBeDone),
                new Task("Cleaning", "Clean the kitchen", DateTime.Now, false, Importance.ItsGottaBeDone),
                new Task("Call someone", "Just a call", DateTime.Now, false, Importance.WhoCouldDoItForMe),
                new Task("Think about somethink", "Thinking", DateTime.Now, false, Importance.DalekDelete),

            };
        }
    }
}
