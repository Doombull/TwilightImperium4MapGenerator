using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwilightImperium4MapGenerator.Models;

namespace TwilightImperium4MapGenerator
{
    internal static class SystemFactory
    {
        public static List<PlanetarySystem> GetPlanetarySystems()
        {
            var list = new List<PlanetarySystem>(new PlanetarySystem[]
            {
                new PlanetarySystem(19, new Planet[]
                {
                    new Planet("Wellon", 1, 2, TechBonus.Yellow)
                }),
                new PlanetarySystem(20, new Planet[]
                {
                    new Planet("Vefut II", 2, 2)
                }),
                new PlanetarySystem(21, new Planet[]
                {
                    new Planet("Thibah", 1, 1, TechBonus.Blue)
                }),
                new PlanetarySystem(22, new Planet[]
                {
                    new Planet("Tar Mann", 1, 1, TechBonus.Green)
                }),
                new PlanetarySystem(23, new Planet[]
                {
                    new Planet("Saudor", 2, 2)
                }),
                new PlanetarySystem(24, new Planet[]
                {
                    new Planet("Mehar Xull", 1, 3, TechBonus.Red)
                }),
                new PlanetarySystem(25, new Planet[]
                {
                    new Planet("Quann", 2, 1)
                }),
                new PlanetarySystem(26, new Planet[]
                {
                    new Planet("Lodor", 3, 1)
                }),
                new PlanetarySystem(27, new Planet[]
                {
                    new Planet("New Albion", 1, 1, TechBonus.Green),
                    new Planet("Starpoint", 3, 1)
                }),
                new PlanetarySystem(28, new Planet[]
                {
                    new Planet("Tequ'ran", 2, 0),
                    new Planet("Torkan", 0, 3)
                }),
                new PlanetarySystem(29, new Planet[]
                {
                    new Planet("Qucen'n", 1, 2),
                    new Planet("Rarron", 0, 3)
                }),
                new PlanetarySystem(30, new Planet[]
                {
                    new Planet("Mellon", 0, 2),
                    new Planet("Zohbat", 3, 1)
                }),
                new PlanetarySystem(31, new Planet[]
                {
                    new Planet("Lazar", 1, 0, TechBonus.Yellow),
                    new Planet("Sakulag", 2, 1)
                }),
                new PlanetarySystem(32, new Planet[]
                {
                    new Planet("Dal Bootha", 0, 2),
                    new Planet("Xxehan", 1, 1)
                }),
                new PlanetarySystem(33, new Planet[]
                {
                    new Planet("Corneeq", 1, 2),
                    new Planet("Resculon", 2, 0)
                }),
                new PlanetarySystem(34, new Planet[]
                {
                    new Planet("Centauri", 1, 3),
                    new Planet("Graal", 1, 1, TechBonus.Blue)
                }),
                new PlanetarySystem(35, new Planet[]
                {
                    new Planet("Bereg", 3, 1),
                    new Planet("Lirta IV", 2, 3)
                }),
                new PlanetarySystem(36, new Planet[]
                {
                    new Planet("Arnor", 2, 1),
                    new Planet("Lor", 1, 2)
                }),
                new PlanetarySystem(37, new Planet[]
                {
                    new Planet("Arinam", 1, 2),
                    new Planet("Meer", 0, 4, TechBonus.Red)
                }),
                new PlanetarySystem(38, new Planet[]
                {
                    new Planet("Abyz", 3, 0),
                    new Planet("Fria", 2, 0)
                }),
                new PlanetarySystem(59, new Planet[]
                {
                    new Planet("Archon Vail", 1, 3, TechBonus.Blue)
                }),
                new PlanetarySystem(60, new Planet[]
                {
                    new Planet("Perimeter", 2, 1)
                }),
                new PlanetarySystem(61, new Planet[]
                {
                    new Planet("Ang", 2, 0, TechBonus.Red)
                }),
                new PlanetarySystem(62, new Planet[]
                {
                    new Planet("Sem-Lore", 3, 2, TechBonus.Yellow)
                }),
                new PlanetarySystem(63, new Planet[]
                {
                    new Planet("Vorhal", 0, 2, TechBonus.Green)
                }),
                new PlanetarySystem(64, new Planet[]
                {
                    new Planet("Atlas", 3, 1)
                }),
                new PlanetarySystem(65, new Planet[]
                {
                    new Planet("Primor", 2, 1, isLegendary: true, miscValue: 1)
                }),
                new PlanetarySystem(66, new Planet[]
                {
                    new Planet("Hope's End", 3, 0, isLegendary: true, miscValue: 2)
                }),
                new PlanetarySystem(67, new Planet[]
                {
                    new Planet("Cormund", 2, 0)
                }),
                new PlanetarySystem(68, new Planet[]
                {
                    new Planet("Everra", 3, 1)
                }),
                new PlanetarySystem(69, new Planet[]
                {
                    new Planet("Accoen", 2, 3),
                    new Planet("Jeol Ir", 2, 3)
                }),
                new PlanetarySystem(70, new Planet[]
                {
                    new Planet("Kraag", 2, 1),
                    new Planet("Siig", 0, 2)
                }),
                new PlanetarySystem(71, new Planet[]
                {
                    new Planet("Ba'kal", 3, 2),
                    new Planet("Alio Prima", 1, 1)
                }),
                new PlanetarySystem(72, new Planet[]
                {
                    new Planet("Lisis", 2, 2),
                    new Planet("Velnor", 2, 1, TechBonus.Red)
                }),
                new PlanetarySystem(73, new Planet[]
                {
                    new Planet("Cealdri", 0, 2, TechBonus.Yellow),
                    new Planet("Xanhact", 0, 1)
                }),
                new PlanetarySystem(74, new Planet[]
                {
                    new Planet("Vega Major", 2, 1),
                    new Planet("Vega Minor", 1, 2, TechBonus.Blue)
                }),
                new PlanetarySystem(75, new Planet[]
                {
                    new Planet("Abaddon", 1, 0),
                    new Planet("Ashtroth", 2, 0),
                    new Planet("Loki", 1, 2)
                }),
                new PlanetarySystem(76, new Planet[]
                {
                    new Planet("Rigel I", 0, 1),
                    new Planet("Rigel II", 1, 2),
                    new Planet("Rigel III", 1, 1, TechBonus.Green)
                })
            });

            return list;
        }


        public static List<ISystem> GetSpacingSystems()
        {
            List<ISystem> list = new List<ISystem>(new ISystem[]
            {
                new EmptySystem(39),
                new EmptySystem(39),
                new AnomalySystem(41, "Gravity Rift"),
                new AnomalySystem(42, "Nebula"),
                new AnomalySystem(43, "Supernova"),
                new AnomalySystem(44, "Asteroid Field"),
                new AnomalySystem(45, "Asteroid Field"),
                new EmptySystem(46),
                new EmptySystem(47),
                new EmptySystem(48),
                new EmptySystem(49),
                new EmptySystem(50),
                new EmptySystem(77),
                new EmptySystem(78),
                new AnomalySystem(79, "Asteroid Field"),
                new AnomalySystem(80, "Supernova")
            });

            return list;
        }
    }
}
