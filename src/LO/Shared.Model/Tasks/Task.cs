namespace Shared.Model.Tasks
{
    /// <summary>
    /// Task modelization.
    /// </summary>
    public class Task : IEquatable<Task>
    {
        #region attributes
        /// <summary>
        /// Task name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Task description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Task creation date.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Task completion state.
        /// </summary>
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Importance of the task.
        /// </summary>
        public Importance Importance { get; set; }

        /// <summary>
        /// Planned time to execute task.
        /// </summary>
        public TimeInterval PlannedTime { get; set; }
        #endregion

        #region constructors
        public Task(string name, string description, DateTime creationDate, bool isCompleted, Importance importance)
        {
            Name = name;
            Description = description;
            CreationDate = creationDate;
            IsCompleted = isCompleted;
            Importance = importance;
        }

        public Task(string name, string description, DateTime creationDate, bool isCompleted, TimeInterval plannedTime, Importance importance) : this(name, description, creationDate, isCompleted, importance)
        {
            PlannedTime = plannedTime;
        }
        #endregion

        #region equality comparer
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            return Equals(obj as Task);
        }

        /// <inheritdoc/>
        public bool Equals(Task? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != GetType()) return false;

            if (!other.Name.Equals(Name)) return false;
            if (!other.Description.Equals(Description)) return false;
            if (!other.CreationDate.Equals(CreationDate)) return false;
            if (!other.IsCompleted.Equals(IsCompleted)) return false;
            if (!other.Importance.Equals(Importance)) return false;

            return other.PlannedTime.Equals(PlannedTime);
        }
        #endregion
    }
}
