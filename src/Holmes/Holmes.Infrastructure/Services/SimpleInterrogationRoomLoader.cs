// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleInterrogationRoomLoader.cs" company="">
//   
// </copyright>
// <summary>
//   The simple interrogation room loader.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Holmes.Infrastructure.Services
{
    using System.Collections.Generic;
    using Holmes.Core.Interfaces;
    using Holmes.Core.Models;

    /// <summary>
    /// The simple interrogation room loader.
    /// </summary>
    public class SimpleInterrogationRoomLoader : IInterrogationRoomRepository
    {
        /// <summary>
        /// The suspect repository.
        /// </summary>
        private readonly ISuspectRepository suspectRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleInterrogationRoomLoader"/> class.
        /// </summary>
        /// <param name="suspectRepository">
        /// The suspect repository.
        /// </param>
        public SimpleInterrogationRoomLoader(ISuspectRepository suspectRepository)
        {
            this.suspectRepository = suspectRepository;
        }

        /// <summary>
        /// The get interrogation rooms.
        /// </summary>
        /// <returns>
        /// The <see cref="List{T}"/>.
        /// </returns>
        public List<InterrogationRoom> GetInterrogationRooms()
        {
            List<InterrogationRoom> rooms = new List<InterrogationRoom>();

            var suspects = this.suspectRepository.GetSuspects();

            foreach (var suspect in suspects)
            {
                rooms.Add(
                    new InterrogationRoom()
                        {
                            Suspect = suspect
                               });
            }

            return rooms;
        }
    }
}
