using XSimulation.Core.Services;

namespace XSimulation.Core.Components
{
    /// <summary>
    /// Defines the interface for all components.
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        /// Gets the component factory (stored the technological parameters).
        /// </summary>
        IComponentFactory Factory
        {
            get;
        }
    }
}
