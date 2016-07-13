using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holmes.Core.Interfaces
{
    using Holmes.Core.Models;

    /// <summary>
    /// The WorldLoadingService interface.
    /// </summary>
    public interface IWorldRepository
    {
        /// <summary>
        /// Gets an instance of the world for the investigation
        /// </summary>
        /// <returns>
        /// The <see cref="World"/>.
        /// </returns>
        World GetWorld();
    }
}
