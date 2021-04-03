using System.Collections.Generic;
using System.Linq;

using Builder.Models.Character.Enums;

namespace Builder.Models.Character
{
    public class Character
    {
        public Character()
        {
            Spells = new List<string>();
            Weapons = new List<string>();
        }

        public int? Age { get; set; }
        public string Name { get; set; }
        public CharacterClasses? Class { get; set; }
        public Gender? Gender { get; set; }
        public List<string> Spells { get; private set; }
        public List<string> Weapons { get; private set; }

        public override string ToString()
        {
            var finalText = "";

            finalText += string.IsNullOrEmpty(Name) ? null : $"Name: {Name}";
            finalText += Age is null ? null : $"\nAge: {Age}";
            finalText += Class is null ? null : $"\nClass: {Class}";
            finalText += Gender is null ? null : $"\nGender: {Gender}";
            finalText += Spells != null && Spells.Any() ? $"\nSpells: [ {string.Join(", ", Spells)} ]" : null;
            finalText += Weapons != null && Weapons.Any() ? $"\nWeapons: [ {string.Join(", ", Weapons)} ]" : null;

            return finalText;
        }
    }
}