namespace Shared.Model.Tasks
{
    /// <summary>
    /// Manages a dictionnary of tasks.
    /// </summary>
    public class TaskManager
    {
        #region attribute
        /// <summary>
        /// Task dictionnary.
        /// </summary>
        private Dictionary<Importance, List<Task>> Tasks { get; set; }
        #endregion

        #region constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="tasks"></param>
        public TaskManager(Dictionary<Importance, List<Task>> tasks)
        {
            Tasks = new Dictionary<Importance, List<Task>>(tasks);
        }
        #endregion

        #region CRUD methods
        /// <summary>
        /// Returns all the tasks.
        /// </summary>
        /// <returns> All the tasks. </returns>
        public Dictionary<Importance, List<Task>> GetTasks()
        {
            return Tasks;
        }

        /// <summary>
        /// Gets tasks for the given importance key.
        /// </summary>
        /// <param name="importance"> Importance key. </param>
        /// <returns> The task list associated with the key. </returns>
        /// <exception cref="ArgumentException"> If the key is not contained in the list. </exception>
        public List<Task> GetTasks(Importance importance)
        {
            if(! Tasks.ContainsKey(importance)) 
            {
                throw new ArgumentException("No entries for given key.");
            }

            return Tasks[importance];
        }

        /// <summary>
        /// Adds a task to the list.
        /// </summary>
        /// <param name="task"> Task to add. </param>
        /// <returns> True if insertion was successful, false otherwise.</returns>
        public bool AddTask(Task task)
        {
            if (!Tasks.ContainsKey(task.Importance))
            {
                return Tasks.TryAdd(task.Importance, new List<Task>() { task });
            }
            else
            {
                if(task.Importance.Equals(Importance.AFrog))
                {
                    Tasks[task.Importance].Clear();
                }

                Tasks[task.Importance].Add(task);
            }

            return true;
        }

        public bool UpdateTaskImportance(Importance importance, Task task)
        {
            if (!Tasks.ContainsKey(task.Importance)) return false;

            var list = Tasks[task.Importance];
            if (!list.Remove(task)) return false;

            if (!Tasks.ContainsKey(importance))
            {
                return Tasks.TryAdd(importance, new List<Task>() { task });
            }

            Tasks[importance].Add(task);

            return true;
        }

        /// <summary>
        /// Remove a task from the list.
        /// </summary>
        /// <param name="task"> Task to remove. </param>
        /// <returns> True if the task could be removed, false otherwise. </returns>
        public bool DeleteTask(Task task)
        {
            if (!Tasks.ContainsKey(task.Importance)) return false;

            var tasks = Tasks[task.Importance];
            return tasks.Remove(task);
        }
        #endregion
    }
}
