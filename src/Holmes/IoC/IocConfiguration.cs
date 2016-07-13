// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IocConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   Utility class to wire up our Dependency Injection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Holmes.Main.IoC
{
    using DryIoc;
    using DryIoc.CommonServiceLocator;

    using Holmes.Core.Interfaces;
    using Holmes.Core.Models;
    using Holmes.Infrastructure.Services;

    using Microsoft.Practices.ServiceLocation;

    /// <summary>
    /// Utility class to wire up our Dependency Injection
    /// </summary>
    public class IocConfiguration
    {
        /// <summary>
        /// The IoC setup is performed here and wired up to the CommonServiceLocator
        /// The CommonServiceLocator is unnecessary for a project of this size and scope
        /// but I wanted to show knowledge of it
        /// </summary>
        public static void Setup()
        {
            var container = new Container();

            // Register the various actors and models
            container.Register<InterrogationRoom>();
            container.Register<Investigation>();
            container.Register<Investigator>();
            container.Register<Suspect>();
            container.Register<World>();

            // Register the repositories 
            container.Register<IInterrogationRoomRepository, SimpleInterrogationRoomLoader>();
            container.Register<IInvestigatorRepository, SimpleInvestigatorLoader>();
            container.Register<ISuspectRepository, SimpleSuspectLoader>();
            container.Register<IWorldRepository, SimpleWorldLoader>();

            // Register the other services
            container.Register<IInvestigationService, HolmesInvestigationService>();

            // Now wire up DryIoC to the Common Service Locator
            var locator = new DryIocServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}