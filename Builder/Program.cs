using Builder.Models;
using Builder.Models.Character;
using Builder.Models.Character.Builders;
using Builder.Models.Home.Builders;
using System;

namespace Builder
{
    class Program
    {
        // TODO: Create a RPG character builder
        // class, genre, skills, weapons, name, spells (if it's a mage)

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Let's start the construction!");

        //    var builder = new HouseBuilder()
        //        .BuildWalls(Materials.Iron)
        //        .BuildDoors(Materials.Stone);

        //    builder.Reset();

        //    var customHouse = builder.Build();

        //    var director = new Director(builder);
        //    var castle = director.BuildCastle();

        //    Console.WriteLine(customHouse);
        //    Console.WriteLine(castle);
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Let's start the construction!");

            var characterWeapons = new string[] { "Long Spear", "Two hands Sword" };

            var character = new CharacterBuilder()
                .SetName("Kruger")
                .SetGender(Gender.Male)
                .SetClass(CharacterClasses.Fighter)
                .SetAge(42)
                .AddWeapon(characterWeapons)
                .Build();

            Console.WriteLine(character);
        }
    }
}
