using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml;
using Leopotam.Ecs;
using XSimulation.Core.Components;
using XSimulation.Core.Data;

namespace XSimulation.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EcsWorld lWorld = new EcsWorld();
            EcsEntity lEcsEntity = lWorld.NewEntity();

            var lEntityId = new EntityIdComponent() { EntityId = 1 };
            lEcsEntity.Replace(lEntityId);

            // Component can be replaced with new instance of component. If component not exist - it will be added.
            var lTransform = new GeoTransformComponent() { Position = new GeoPosition(), Attitude = new Attitude() };
            lEcsEntity.Replace(lTransform);
            
            var lStaticKinematicComponent = new StaticKinematicComponent() { };
            lEcsEntity.Replace(lStaticKinematicComponent);

            object[] lResults = new object[1];
            lEcsEntity.GetComponentValues(ref lResults);
            JsonSerializerOptions lOptions = new JsonSerializerOptions {WriteIndented = true};
            var json = JsonSerializer.Serialize(lResults.ToList(), lOptions);
            File.WriteAllText(@"d:\json-2.txt", json);

            List<object> lComponents = JsonSerializer.Deserialize<List<object>>(json);

            Console.WriteLine(lEcsEntity.GetInternalId());
        }
    }
}
