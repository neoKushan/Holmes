using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holmes.Core.BaseClasses
{
    /// <summary>
    /// Suspects and investigators will have a base class,
    /// Actor is that base class
    /// </summary>
    public class Actor
    {
        /// <summary>
        /// Gets or sets The name of the actor
        /// </summary>
        public string Name { get; set; }
    }
}
