using Leopotam.Ecs;

namespace XSimulation.Core.Services
{
    /// <summary>
    /// This class references all entity definition and all categories.
    /// </summary>
    public class LocalEntityDatabase
    {
        /// <summary>
        /// Sets the source for all the database.
        /// Each folder is considered as category.
        /// Each file is considered as an entity prototype.
        /// </summary>
        public string Source
        {
            get;
            set;
        }

        /// <summary>
        /// Loads all factories.
        /// </summary>
        /// <returns>The number of loaded factories</returns>
        public int Load()
        {
            return 0;
        }

        public bool SwitchSource(string pDatabaseName)
        {
            return false;
        }

        public EcsEntity Create(string pEntityFactoryName)
        {
            return default(EcsEntity);
        }
    }
}
