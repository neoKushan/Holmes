// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWorldRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The WorldLoadingService interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Holmes.Core.Interfaces
{
    using Holmes.Core.Models;

    /// <summary>
    /// The WorldLoadingService interface.
    /// </summary>
    public interface IWorldRepository
    {
        /// <summary>
        /// Gets an instance of the world for the investigation
        /// </summary>
        /// <returns>
        /// The <see cref="World"/>.
        /// </returns>
        World GetWorld();
    }
}