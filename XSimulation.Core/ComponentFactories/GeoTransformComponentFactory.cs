using XSimulation.Core.Components;
using XSimulation.Core.Services;

namespace XSimulation.Core.ComponentFactories
{
    /// <summary>
    /// A factory for GeoTransformComponent.
    /// </summary>
    public class GeoTransformComponentFactory : ITypedComponentFactory<GeoTransformComponent>
    {
        /// <inheritdoc />
        public GeoTransformComponent Create()
        {
            GeoTransformComponent lComponent = new GeoTransformComponent
            {
                Factory = this
            };
            return lComponent;
        }
    }
}