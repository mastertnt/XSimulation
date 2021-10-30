namespace XSimulation.Core.Services
{
    /// <summary>
    /// Defines a component factory.
    /// </summary>
    public interface ITypedComponentFactory<out TComponentType> : IComponentFactory where TComponentType : struct
    {
        /// <summary>
        /// Creates the component.
        /// </summary>
        /// <returns>The created component, null otherwise.</returns>
        TComponentType Create();
    }
}
