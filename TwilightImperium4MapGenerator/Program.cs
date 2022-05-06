using TwilightImperium4MapGenerator;
using TwilightImperium4MapGenerator.Models;

//Console.WriteLine("*******************");
//Console.WriteLine("****** All Systems");
//Console.WriteLine("*******************");

//var spacingSystems = SystemFactory.GetSpacingSystems();
//spacingSystems.Shuffle();

//var planetarySystems = SystemFactory.GetPlanetarySystems();
//planetarySystems.Sort();

//foreach (var system in planetarySystems)
//    Console.WriteLine("{0} {1} - {2}", system.GetValue().ToString("0.000"), system.Id, system.GetName());


//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("************************");
//Console.WriteLine("****** Starting Sectors");
//Console.WriteLine("************************");

//var sectors = GalaxyFactory.Get8PlayerGalaxy(planetarySystems, spacingSystems);

//int i = 0;
//foreach (var sector in sectors)
//{
//    i++;

//    Console.WriteLine("");
//    Console.WriteLine("** Player {0} - Value {1}", i.ToString(), sector.GetValue());
//    Console.WriteLine();

//    foreach (var system in sector.Systems)
//        Console.WriteLine("{0} {1} - {2}", system.GetValue().ToString("0.000"), system.Id, system.GetName());
//}

Galaxy? galaxy = null;
while (galaxy is null)
{
    var spacingSystems = SystemFactory.GetSpacingSystems();
    spacingSystems.Shuffle();

    var planetarySystems = SystemFactory.GetPlanetarySystems();
    planetarySystems.Sort();

    galaxy = GalaxyFactory.Get8PlayerGalaxy(planetarySystems, spacingSystems);

    if (galaxy is null)
    {
        Console.WriteLine("Not enough resources, trying again...");
        Console.WriteLine();
    }
}

//Console.WriteLine("https://keeganw.github.io/ti4" + settings);
Console.WriteLine(galaxy.ToString());