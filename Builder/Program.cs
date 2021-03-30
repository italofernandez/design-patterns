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

        static void Main(string[] args)
        {
            Console.WriteLine("Let's start building your character!");

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
