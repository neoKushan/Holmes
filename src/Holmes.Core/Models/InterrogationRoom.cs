// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterrogationRoom.cs" company="">
// </copyright>
// <summary>
//   The interrogation room, which contains a single suspect and potentially
//   an investigator
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Holmes.Core.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The interrogation room, which contains a single suspect and potentially
    /// an investigator
    /// </summary>
    public class InterrogationRoom
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterrogationRoom"/> class. 
        /// </summary>
        public InterrogationRoom()
        {
            this.Investigators = new List<Investigator>();
        }

        /// <summary>
        /// Gets or sets the list of Investigators in the room
        /// </summary>
        public List<Investigator> Investigators { get; set; } // = new List<Investigator>(); // C# 6 feature :(

        /// <summary>
        /// Gets or sets the current suspect present in the room
        /// </summary>
        public Suspect Suspect { get; set; }
    }
}