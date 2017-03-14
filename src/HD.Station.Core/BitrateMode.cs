using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    /// <summary>
    /// Representation of type of bitrate: constant or variable.
    /// </summary>
    public enum BitrateMode
    {
        /// <summary>
        /// The bitrate is set to "constant".
        /// </summary>
        Constant = 0,

        /// <summary>
        /// The bitrate is set to "variable".
        /// </summary>
        Variable = 1
    }
}