using XSimulation.Core.Data;
using XSimulation.Core.Services;

namespace XSimulation.Core.Components
{
    /// <summary>
    /// A component used to locate and orientate an entity in the world.
    /// </summary>
    public struct GeoTransformComponent : IComponent
    {
        /// <summary>
        /// The geographic position with the altitude.
        /// </summary>
        public GeoPosition Position
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the attitude of the transform (Yaw, Pitch, Roll).
        /// Yaw is considered as the heading.
        /// </summary>
        public Attitude Attitude
        {
            get;
            set;
        }

        /// <inheritdoc />
        public IComponentFactory Factory
        {
            get;
            internal set;
        }
    }
}
