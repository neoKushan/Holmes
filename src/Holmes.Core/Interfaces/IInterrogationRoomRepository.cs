// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IInterrogationRoomRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The InterrogationRoomRepository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Holmes.Core.Interfaces
{
    using System.Collections.Generic;
    using Holmes.Core.Models;

    /// <summary>
    /// The InterrogationRoomRepository interface.
    /// </summary>
    public interface IInterrogationRoomRepository
    {
        /// <summary>
        /// The get interrogation rooms method.
        /// </summary>
        /// <returns>
        /// The <see cref="List{T}"/>.
        /// </returns>
        List<InterrogationRoom> GetInterrogationRooms();
    }
}
