using System.IO;
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
        /// EAch file is considered as an entity prototype.
        /// </summary>
        public string Source
        {
            get;
            set;
        }

        bool Load()
        {
            return false;
        }

        bool Change(string pDatabaseName)
        {
            return false;
        }
        
        public EcsEntity Create(string pEntityFactoryName)
        {
            return default(EcsEntity);
        }
    }
}
