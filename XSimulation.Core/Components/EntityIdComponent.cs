namespace XSimulation.Core.Components
{
    public struct EntityIdComponent
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
    }
}
 