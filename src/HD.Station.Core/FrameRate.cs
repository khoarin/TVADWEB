using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    public enum FrameRate
    {
        /// <summary>
        /// Framerate = 24 frame/s
        /// </summary>
        NTC = 0,
        /// <summary>
        /// Framerate = 25 frame/s
        /// </summary>
        PAL = 1,
        /// <summary>
        /// Framerate = 30 frame/s
        /// </summary>
        NTSC = 2

    }
}
