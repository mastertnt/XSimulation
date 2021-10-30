using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using XSimulation.Core.ComponentFactories;
using XSimulation.Core.Json;
using XSimulation.Core.Services;

namespace XSimulation.Server
{
    class Program
    {
        static void Main(string[] pArguments)
        {
            ComponentCollectionFactory lEntityFactory = new ComponentCollectionFactory
            {
                Id = "Rafale"
            };

            EntityIdFactory lEntityIdFactory = new EntityIdFactory();
            lEntityFactory.Factories.Add(lEntityIdFactory);

            GeoTransformComponentFactory lGeoTransformComponentFactory = new GeoTransformComponentFactory();
            lEntityFactory.Factories.Add(lGeoTransformComponentFactory);

            string json = JsonConvert.SerializeObject(lEntityFactory, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Auto,
                SerializationBinder = new KnownTypesBinder
                {
                    KnownTypes = new List<Type>
                    {
                        typeof(EntityIdFactory),
                        typeof(GeoTransformComponentFactory)
                    }
                }
            });
            File.WriteAllText(@"c:\temp\json-2.txt", json);

            ComponentCollectionFactory lEntityFactory2 = JsonConvert.DeserializeObject<ComponentCollectionFactory>(json, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Auto,
                SerializationBinder = new KnownTypesBinder
                {
                    KnownTypes = new List<Type>
                    {
                        typeof(EntityIdFactory),
                        typeof(GeoTransformComponentFactory)
                    }
                }
            });

            string json3 = JsonConvert.SerializeObject(lEntityFactory2, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Auto,
                SerializationBinder = new KnownTypesBinder
                {
                    KnownTypes = new List<Type>
                    {
                        typeof(EntityIdFactory),
                        typeof(GeoTransformComponentFactory)
                    }
                }
            });
            File.WriteAllText(@"c:\temp\json-3.txt", json3);
        }
    }
}
