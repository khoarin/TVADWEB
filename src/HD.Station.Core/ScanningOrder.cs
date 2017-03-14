using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    /// <summary>
    /// Scanning order representation: whether the fields are ordered top (upper) or bottom (lower) field first.
    /// </summary>
    public enum ScanningOrder
    {
        TopFieldFirst = 0,
        BottomFieldFirst = 1
    }
}