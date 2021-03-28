using System;
using System.Collections.Generic;

namespace Builder.Models.Character
{
    public class Character
    {
        public Character()
        {
            Spells = System.Array.Empty<string>();
            Weapons = System.Array.Empty<string>();
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public CharacterClasses Class { get; set; }
        public Gender Gender { get; set; }
        public string[] Spells { 
            get => Spells; 
            set {
                if (Class is CharacterClasses.Cleric || Class is CharacterClasses.Mage)
                    Spells = value;
                else
                    throw new IncompatibleClassAttribuition();
            }}
        public string[] Weapons { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} - {Age}\n" +
                $"Class: {Class}\n" +
                $"Gender: {Gender}\n" +
                $"Spells: [ {string.Join(",", Spells)} ]\n" +
                $"Weapons: [ {string.Join(",", Weapons)} ]\n";
        }
    }

    public enum Gender { Male, Female }
    public enum CharacterClasses { Fighter, Assassin, Mage, Archer, Berserker, Cleric }

    class IncompatibleClassAttribuition : Exception { }
}
