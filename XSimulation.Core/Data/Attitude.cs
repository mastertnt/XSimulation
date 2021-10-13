using QuantityTypes;

namespace XSimulation.Core.Data
{
    /// <summary>
    /// Represents an attitude.
    /// </summary>
    public class Attitude
    {
        /// <summary>
        /// Represents the yaw in radians.
        /// </summary>
        public Angle Yaw;

        /// <summary>
        /// Represents the altitude in radians.
        /// </summary>
        public Angle Pitch;

        /// <summary>
        /// Represents the altitude in radians.
        /// </summary>
        public Angle Roll;
    }
}
