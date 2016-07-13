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
    using System;

    using Holmes.Core.BaseClasses;

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
    public class Investigator : Actor
    {
        /// <summary>
        /// Gets or sets the length of time that each interrogation takes
        /// </summary>
        public TimeSpan InterrogationTime { get; set; }

        /// <summary>
        /// Gets or sets the Interrogation time remaining for the current suspect
        /// </summary>
        public TimeSpan RemainingInterrogationTime { get; set; }

        /// <summary>
        /// Gets or sets the Movement Direction of the Investigator
        /// </summary>
        public MovementDirection MovementDirection { get; set; }
    }
}
