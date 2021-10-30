using System.Collections.ObjectModel;
using Leopotam.Ecs;

namespace XSimulation.Core.Services
{
    public class ComponentCollectionFactory
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets all component factories.
        /// </summary>
        public ObservableCollection<IComponentFactory> Factories
        {
            get;
            set;
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ComponentCollectionFactory()
        {
            this.Factories = new ObservableCollection<IComponentFactory>();
        }

        EcsEntity Create()
        {
            return default(EcsEntity);
        }
    }
}
