﻿using QuantityTypes;

namespace XSimulation.Core.Data
{
    /// <summary>
    /// Represents a geographic position with an altitude.
    /// </summary>
    public struct GeoPosition
    {
        /// <summary>
        /// Represents the latitude in degrees from -90 to 90.
        /// </summary>
        public double Latitude
        {
            get;
            set;
        }

        /// Represents the longitude in degrees from -180 to 180.
        public double Longitude
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the altitude.
        /// </summary>
        public Length Altitude
        {
            get;
            set;
        }
    }
}
