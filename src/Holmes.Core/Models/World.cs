// --------------------------------------------------------------------------------------------------------------------
// <copyright file="World.cs" company="">
//   
// </copyright>
// <summary>
//   Our World class contains everything that's in our world, such as rooms, investigators and suspects
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Holmes.Core.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Our World class contains everything that's in our world, such as rooms, investigators and suspects
    /// </summary>
    public class World
    {
        /// <summary>
        /// Gets or sets the list of interrogation rooms within the world
        /// </summary>
        public List<InterrogationRoom> InterrogationRooms { get; set; }

        /// <summary>
        /// Gets or sets the list of investigators present within the world
        /// </summary>
        public List<Investigator> Investigators { get; set; }
    }
}
