// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleWorldLoader.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the SimpleWorldLoader type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Holmes.Infrastructure.Services
{
    using System;

    using Holmes.Core.Interfaces;
    using Holmes.Core.Models;

    /// <summary>
    /// Simple repository to return the world from the brief, could be replaced with a different world
    /// </summary>
    public class SimpleWorldLoader : IWorldRepository
    {
        private object interrogationRoomService;

        /// <summary>
        /// Creates the world as defined by the brief
        /// </summary>
        /// <returns>
        /// The <see cref="World"/>.
        /// </returns>
        public World GetWorld()
        {
            object investigatorService;
            World world = new World
                              {
                                  CurrentTime = DateTime.Now,
                                  Investigators = investigatorService.GetInvestigators(),
                                  InterrogationRooms = interrogationRoomService.GetInterrogationRooms()
                              };

            return world;
        }
    }
}
