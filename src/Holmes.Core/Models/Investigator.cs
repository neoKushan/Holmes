// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Investigator.cs" company="">
//  
// </copyright>
// <summary>
//   Defines the Investigator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Holmes.Core.Models
{
    /// <summary>
    /// The movement direction.
    /// </summary>
    public enum MovementDirection
    {
        /// <summary>
        /// Moves clockwise.
        /// </summary>
        Clockwise,

        /// <summary>
        /// Moves anticlockwise.
        /// </summary>
        Anticlockwise
    }

    /// <summary>
    /// The investigator will be interrogating the suspects
    /// </summary>
    public class Investigator
    {
        /// <summary>
        /// Gets or sets the length of time, in seconds, that each interrogation takes
        /// </summary>
        public int InterrogationTime { get; set; }

        /// <summary>
        /// Gets or sets the Movement Direction of the Investigator
        /// </summary>
        public MovementDirection MovementDirection { get; set; }
    }
}
