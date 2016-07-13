// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
// </copyright>
// <summary>
//   Entrypoint of the application
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Holmes.Main
{
    using System;

    using Holmes.Infrastructure.Services;
    using Holmes.Main.IoC;

    using Microsoft.Practices.ServiceLocation;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            // Start by configuring all of our IoC
            IocConfiguration.Setup();

            // Then create an instance of the investigation
            var investigation = ServiceLocator.Current.GetInstance<Investigation>();

            // Finally investigate!
            var investigationText = investigation.PerformInvestigation();
            Console.Write(investigationText);

            // Wait for input
            Console.ReadKey();
        }
    }
}