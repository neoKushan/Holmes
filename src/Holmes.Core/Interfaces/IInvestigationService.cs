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

    /// <summary>
    /// The InvestigationService interface.
    /// </summary>
    public interface IInvestigationService
    {
        /// <summary>
        /// Moves the "world" along by the defined Timespan
        /// </summary>
        /// <param name="timeToInvestigate">How far to move the world along by</param>
        void Investigate(TimeSpan timeToInvestigate);
    }
}
