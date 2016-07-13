// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HolmesInvestigationService.cs" company="">
// </copyright>
// <summary>
//   The holmes investigation service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Holmes.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Holmes.Core.Interfaces;
    using Holmes.Core.Models;

    /// <summary>
    /// The holmes investigation service.
    /// </summary>
    public class HolmesInvestigationService : IInvestigationService
    {
        /// <summary>
        /// The investigate method.
        /// </summary>
        /// <param name="world">
        /// The world to investigate.
        /// </param>
        /// <param name="timeToInvestigate">
        /// The time to advance the investigation by.
        /// </param>
        /// <param name="investigationText">
        /// The investigation text, append to this anything interesting.
        /// </param>
        /// <returns>
        /// The <see cref="InvestigationResult"/>.
        /// </returns>
        public InvestigationResult Investigate(
            World world, 
            TimeSpan timeToInvestigate, 
            ref StringBuilder investigationText)
        {
            // The world moves forward by this amount
            world.CurrentTime += timeToInvestigate;

            // Find each investigator and advance them through the world
            foreach (var investigator in world.Investigators)
            {
                investigator.RemainingInterrogationTime -= timeToInvestigate;

                if (investigator.RemainingInterrogationTime.Seconds < 1)
                {
                    // Find the room they're currently in and move them to the next room
                    this.MoveRooms(investigator, world.InterrogationRooms, ref investigationText);

                    // Check success conditions
                    bool allAgentsInSameRoom =
                        world.InterrogationRooms.Any(x => x.Investigators.Count == world.Investigators.Count);
                    if (allAgentsInSameRoom)
                    {
                        return InvestigationResult.SuspectFound;
                    }

                    // Check two investigators aren't in a room if they both work alone
                    if (investigator.WorksAlone)
                    {
                        var currentRoom = this.GetCurrentRoom(investigator, world.InterrogationRooms);
                        if (currentRoom.Investigators.Count > 1 && currentRoom.Investigators.All(x => x.WorksAlone))
                        {
                            investigationText.AppendLine(
                                string.Format(
                                    "Not wanting to disturb his colleague, {0} continues on to the next room", 
                                    investigator.Name));
                            this.MoveRooms(investigator, world.InterrogationRooms, ref investigationText);
                        }
                    }

                    // Restart the clock in the next room
                    investigator.RemainingInterrogationTime = investigator.InterrogationTime;
                }
            }

            return InvestigationResult.Inconclusive;
        }

        /// <summary>
        /// Gets the current room the investigator is in
        /// </summary>
        /// <param name="investigator">
        /// The investigator.
        /// </param>
        /// <param name="interrogationRooms">
        /// The interrogation rooms.
        /// </param>
        /// <returns>
        /// The <see cref="InterrogationRoom"/>.
        /// </returns>
        private InterrogationRoom GetCurrentRoom(Investigator investigator, List<InterrogationRoom> interrogationRooms)
        {
            var currentRoom = interrogationRooms.Find(x => x.Investigators.Contains(investigator));
            return currentRoom;
        }

        /// <summary>
        /// The move rooms.
        /// </summary>
        /// <param name="investigator">
        ///     The investigator to move.
        /// </param>
        /// <param name="interrogationRooms">
        ///     The list interrogation rooms.
        /// </param>
        /// <param name="investigationText">Append investigation text to this </param>
        private void MoveRooms(
            Investigator investigator, 
            List<InterrogationRoom> interrogationRooms, 
            ref StringBuilder investigationText)
        {
            // Find the room they're currently in
            var currentRoom = this.GetCurrentRoom(investigator, interrogationRooms);

            investigationText.AppendLine(
                string.Format(
                    "{0} grows weary of {1} and decides to move onto the next room", 
                    investigator.Name, 
                    currentRoom.Suspect.Name));

            // Remove the investigator from the room
            currentRoom.Investigators.Remove(investigator);

            // Find the position of that room
            var position = interrogationRooms.IndexOf(currentRoom);

            // Move the investigator depending on their movement direction
            if (investigator.MovementDirection == MovementDirection.Clockwise)
            {
                // Move them to the next room
                position++;
                if (position > interrogationRooms.Count - 1)
                {
                    // Go back to the position
                    position = 0;
                }
            }
            else
            {
                // Move them to the next room
                position--;
                if (position < 0)
                {
                    // Go back to the position
                    position = interrogationRooms.Count - 1;
                }
            }

            // Place the investigator into the next room
            var nextRoom = interrogationRooms[position];
            nextRoom.Investigators.Add(investigator);

            investigationText.AppendLine(
                string.Format(
                    "{0} meets face to face with {1}, the investigation continues", 
                    investigator.Name, 
                    nextRoom.Suspect.Name));
        }
    }
}