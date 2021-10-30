using XSimulation.Core.Services;

namespace XSimulation.Core.Components
{
    /// <summary>
    /// An entity id component.
    /// </summary>
    public struct EntityIdComponent : IComponent
    {
        /// <summary>
        /// Defines the entity identifier from 1 to 65535
        /// Must be different among all entities.
        /// </summary>
        public ushort EntityId
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
 