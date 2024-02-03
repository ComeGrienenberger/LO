using System.Diagnostics.CodeAnalysis;

namespace Shared.Model.Tasks
{
    /// <summary>
    /// Represents a TimeInterval.
    /// </summary>
    public struct TimeInterval
    {
        /// <summary>
        /// The beginning of the time interval.
        /// </summary>
        public DateTime Beginning { get; set; } 

        /// <summary>
        /// The ending of the time interval.s
        /// </summary>
        public DateTime Ending { get; set; }

        /// <inheritdoc/>
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj is null) return false;
            if(ReferenceEquals(this, obj)) return true;
            if(obj.GetType() != typeof(TimeInterval)) return false;

            var ti = (TimeInterval) obj;

            if (! ti.Beginning.Equals(Beginning)) return false;

            return ti.Ending.Equals(Ending);
        }
    }
}
