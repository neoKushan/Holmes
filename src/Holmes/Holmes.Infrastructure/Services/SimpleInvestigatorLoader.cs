// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleInvestigatorLoader.cs" company="">
// </copyright>
// <summary>
//   Defines the SimpleInvestigatorLoader type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Holmes.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;

    using Holmes.Core.Interfaces;
    using Holmes.Core.Models;

    /// <summary>
    /// The simple investigator loader.
    /// </summary>
    public class SimpleInvestigatorLoader : IInvestigatorRepository
    {
        /// <summary>
        /// The get investigators.
        /// </summary>
        /// <returns>
        /// The <see cref="List{T}"/>.
        /// </returns>
        public List<Investigator> GetInvestigators()
        {
            var investigators = new List<Investigator>()
                                     {
                                         new Investigator()
                                             {
                                                 Name = "Holmes", 
                                                 InterrogationTime =
                                                     TimeSpan
                                                     .FromMinutes(15), 
                                                 MovementDirection =
                                                     MovementDirection
                                                     .Clockwise
                                             }, 
                                         new Investigator()
                                             {
                                                 Name = "Watson", 
                                                 InterrogationTime =
                                                     TimeSpan
                                                     .FromMinutes(20), 
                                                 MovementDirection =
                                                     MovementDirection
                                                     .Anticlockwise
                                             }, 
                                         new Investigator()
                                             {
                                                 Name = "Wellington", 
                                                 InterrogationTime =
                                                     TimeSpan
                                                     .FromMinutes(30), 
                                                 MovementDirection =
                                                     MovementDirection
                                                     .Anticlockwise
                                             }
                                     };

            return investigators;
        }
    }
}