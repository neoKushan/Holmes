// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleWorldLoader.cs" company="">
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
        /// <summary>
        /// The interrogation room service.
        /// </summary>
        private readonly IInterrogationRoomRepository interrogationRoomService;

        /// <summary>
        /// The investigator repository.
        /// </summary>
        private readonly IInvestigatorRepository investigatorService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleWorldLoader"/> class.
        /// </summary>
        /// <param name="interrogationRoomService">
        /// The interrogation room service.
        /// </param>
        /// <param name="investigatorService">
        /// The investigator Service.
        /// </param>
        public SimpleWorldLoader(
            IInterrogationRoomRepository interrogationRoomService, 
            IInvestigatorRepository investigatorService)
        {
            this.interrogationRoomService = interrogationRoomService;
            this.investigatorService = investigatorService;
        }

        /// <summary>
        /// Creates the world as defined by the brief
        /// </summary>
        /// <returns>
        /// The <see cref="World"/>.
        /// </returns>
        public World GetWorld()
        {
            World world = new World
                              {
                                  CurrentTime = DateTime.Now, 
                                  Investigators = this.investigatorService.GetInvestigators(), 
                                  InterrogationRooms = this.interrogationRoomService.GetInterrogationRooms()
                              };

            // Now set up the default world by placing the investigators into their respective rooms.
            world.InterrogationRooms.Find(x => x.Suspect.Name == "Mustard")
                .Investigators.Add(world.Investigators.Find(x => x.Name == "Holmes"));
            world.InterrogationRooms.Find(x => x.Suspect.Name == "White")
                .Investigators.Add(world.Investigators.Find(x => x.Name == "Watson"));
            world.InterrogationRooms.Find(x => x.Suspect.Name == "Mustard")
                .Investigators.Add(world.Investigators.Find(x => x.Name == "Wellington"));

            return world;
        }
    }
}