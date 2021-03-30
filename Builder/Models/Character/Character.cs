using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder.Models.Character
{
    public class Character
    {
        public Character()
        {
            Spells = new List<string>();
            Weapons = new List<string>();
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public CharacterClasses Class { get; set; }
        public Gender Gender { get; set; }
        public List<string> Spells { get; private set; }
        public List<string> Weapons { get; private set; }

        public override string ToString()
        {
            var finalText = "";

            finalText += string.IsNullOrEmpty(Name) ? null : $"Name: {Name}\n";
            finalText += $"Age: {Age}\n";
            finalText += $"Class: {Class}\n";
            finalText += $"Gender: {Gender}\n";
            finalText += Spells != null && Spells.Any() ? $"Spells: [ {string.Join(",", Spells)} ]\n" : null;
            finalText += Weapons != null && Weapons.Any() ? $"Weapons: [ {string.Join(",", Weapons)} ]\n" : null;

            return finalText;
        }
    }

    public enum Gender { Male, Female }
    public enum CharacterClasses { Fighter, Assassin, Mage, Archer, Berserker, Cleric }
    class IncompatibleCharaterClassAttribuition : Exception { }
}
