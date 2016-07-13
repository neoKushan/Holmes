// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleSuspectLoader.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the SimpleSuspectLoader type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Holmes.Infrastructure.Services
{
    using System.Collections.Generic;

    using Holmes.Core.Interfaces;
    using Holmes.Core.Models;

    /// <summary>
    /// The simple suspect loader.
    /// </summary>
    public class SimpleSuspectLoader : ISuspectRepository
    {
        /// <summary>
        /// The get suspects.
        /// </summary>
        /// <returns>
        /// The <see cref="List{T}"/>.
        /// </returns>
        public List<Suspect> GetSuspects()
        {
            List<Suspect> suspects = new List<Suspect>()
                                         {
                                             new Suspect() { Name = "Mustard" },
                                             new Suspect() { Name = "Green" },
                                             new Suspect() { Name = "Plum" },
                                             new Suspect() { Name = "Peacock" },
                                             new Suspect() { Name = "Scarlett" },
                                             new Suspect() { Name = "White" }
                                         };

            return suspects;
        }
    }
}
