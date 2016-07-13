// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IInvestigationService.cs" company="">
//   
// </copyright>
// <summary>
//   The InvestigationService interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Holmes.Core.Interfaces
{
    using System;
    using System.Text;

    using Holmes.Core.Models;

    /// <summary>
    /// The investigation result.
    /// </summary>
    public enum InvestigationResult
    {
        /// <summary>
        /// The investigation is currently inconclusive.
        /// </summary>
        Inconclusive,

        /// <summary>
        /// The suspect has been found.
        /// </summary>
        SuspectFound
    }

    /// <summary>
    /// The InvestigationService interface.
    /// </summary>
    public interface IInvestigationService
    {
        /// <summary>
        /// Moves the "world" along by the defined Timespan
        /// </summary>
        /// <param name="world">
        /// The world to investigate.
        /// </param>
        /// <param name="timeToInvestigate">
        /// How far to move the world along by
        /// </param>
        /// <param name="investigationText">
        /// The text results of the investigation step
        /// </param>
        /// <returns>
        /// The <see cref="InvestigationResult"/> of the investigation step.
        /// </returns>
        InvestigationResult Investigate(World world, TimeSpan timeToInvestigate, ref StringBuilder investigationText);
    }
}
