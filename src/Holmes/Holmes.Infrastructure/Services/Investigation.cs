// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Investigation.cs" company="">
// </copyright>
// <summary>
//   Defines the Investigation type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Holmes.Infrastructure.Services
{
    using System;
    using System.Linq;
    using System.Text;

    using Holmes.Core.Interfaces;

    /// <summary>
    /// The investigation, effectively this is the logic of the investigation.
    /// </summary>
    public class Investigation
    {
        /// <summary>
        /// The investigation service.
        /// </summary>
        private readonly IInvestigationService investigationService;

        /// <summary>
        /// The world loading service.
        /// </summary>
        private readonly IWorldRepository worldLoadingService;

        /// <summary>
        /// Initializes a new instance of the <see cref="Investigation"/> class.
        /// </summary>
        /// <param name="worldLoadingService">
        /// The world Loading Service.
        /// </param>
        /// <param name="investigationService">The investigation service</param>
        public Investigation(IWorldRepository worldLoadingService, IInvestigationService investigationService)
        {
            this.worldLoadingService = worldLoadingService;
            this.investigationService = investigationService;
            this.InvestigationTimeStep = TimeSpan.FromMinutes(5);
        }

        /// <summary>
        /// Gets or sets the investigation time step to use. Defaults to 5 minutes
        /// </summary>
        public TimeSpan InvestigationTimeStep { get; set; }

        /// <summary>
        /// Run the investigation scenario
        /// </summary>
        /// <returns>
        /// The <see cref="string"/> of the investigation.
        /// </returns>
        public string PerformInvestigation()
        {
            // We'll use a stringbuilder for performance reasons
            StringBuilder sb = new StringBuilder();
            var world = this.worldLoadingService.GetWorld();
            var startTime = world.CurrentTime;
            var investigationResult = InvestigationResult.Inconclusive;

            // We'll pull the number of suspects out using a Linq query under the assumption that
            // a room might be empty (even though in this example it won't be)
            var numberOfSuspects = world.InterrogationRooms.Select(x => x.Suspect != null).Count();

            // Intro text
            sb.AppendLine(
                string.Format(
                    "It was a dark and stormy night, the time was {0} and {1} suspects awaited their fate.", 
                    world.CurrentTime.ToString("t"), 
                    numberOfSuspects));

            while (investigationResult == InvestigationResult.Inconclusive)
            {
                investigationResult = this.investigationService.Investigate(world, this.InvestigationTimeStep, ref sb);
            }

            var currentRoom = world.InterrogationRooms.Find(x => x.Investigators.Contains(world.Investigators[0]));

            sb.AppendLine(
                string.Format("It would appear that {0} is guilty of stealing the silver", currentRoom.Suspect.Name));
            sb.AppendLine(string.Format("Investigation started at {0}", startTime));
            sb.AppendLine(string.Format("Investigation finished at {0}", world.CurrentTime));
            sb.AppendLine(string.Format("Total Investigation time: {0}", world.CurrentTime - startTime));

            // return the investigation text
            return sb.ToString();
        }
    }
}