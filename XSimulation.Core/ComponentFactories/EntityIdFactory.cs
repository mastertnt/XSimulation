using XSimulation.Core.Components;
using XSimulation.Core.Services;

namespace XSimulation.Core.ComponentFactories
{
    /// <summary>
    ///     A factory for EntityIdComponent.
    /// </summary>
    public class EntityIdFactory : ITypedComponentFactory<EntityIdComponent>
    {
        /// <inheritdoc />
        public EntityIdComponent Create()
        {
            EntityIdComponent lComponent = new()
            {
                Factory = this
            };
            return lComponent;
        }
    }
}