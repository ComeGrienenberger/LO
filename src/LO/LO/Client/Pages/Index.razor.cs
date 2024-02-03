using LO.Api.Contracts;
using Microsoft.AspNetCore.Components;

using Task = Shared.Model.Tasks.Task;

namespace LO.Client.Pages
{
    public partial class Index
    {
        [Inject]
        private ITasksApi _tasksApi { get; set; }
    }
}
