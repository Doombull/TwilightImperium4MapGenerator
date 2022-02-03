using TwilightImperium4MapGenerator;

var planetarySystems = SystemFactory.GetPlanetarySystems();
planetarySystems.Sort();

foreach (var system in planetarySystems)
    Console.WriteLine("{0} {1} - {2}", system.GetValue().ToString("0.000"), system.Id, system.GetName());


var spacingSystems = SystemFactory.GetSpacingSystems();

foreach (var system in spacingSystems)
    Console.WriteLine("{0} - {1}", system.Id, system.GetName());