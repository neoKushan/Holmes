// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISuspectRepository.cs" company="">
// </copyright>
// <summary>
//   The SuspectRepository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Holmes.Core.Interfaces
{
    using System.Collections.Generic;

    using Holmes.Core.Models;

    /// <summary>
    /// The SuspectRepository interface.
    /// </summary>
    public interface ISuspectRepository
    {
        /// <summary>
        /// The get suspects.
        /// </summary>
        /// <returns>
        /// The <see cref="List{T}"/>.
        /// </returns>
        List<Suspect> GetSuspects();
    }
}