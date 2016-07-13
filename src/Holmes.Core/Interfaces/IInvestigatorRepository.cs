// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IInvestigatorRepository.cs" company="">
// </copyright>
// <summary>
//   The InvestigatorRepository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Holmes.Core.Interfaces
{
    using System.Collections.Generic;

    using Holmes.Core.Models;

    /// <summary>
    /// The InvestigatorRepository interface.
    /// </summary>
    public interface IInvestigatorRepository
    {
        /// <summary>
        /// The get investigators method.
        /// </summary>
        /// <returns>
        /// The <see cref="List{T}"/>.
        /// </returns>
        List<Investigator> GetInvestigators();
    }
}