using System;
using System.Linq;
using Builder.Models.Character.Exceptions;
using Builder.Models.Character.Enums;
using Builder.Models.Character.Builders.Interfaces;

namespace Builder.Models.Character.Builders
{
    public class GenericCharacterBuilder : IGenericCharacterBuilder
    {
        private Character Character;

        public GenericCharacterBuilder()
            => this.Reset();

        public Character Build() 
        {
            if(Character.Class is null)
                throw new UndefinedPropertyException("Class");
            
            if(!CanItCastSpells() && Character.Spells.Any())
                throw new IncompatibleCharaterClassAttribuitionException();
            
            return Character;
        }

        public void Reset()
            => Character = new Character();

        public IGenericCharacterBuilder AddWeapon(string weapon)
        {
            Character.Weapons.Add(weapon);
            return this;
        }

        public IGenericCharacterBuilder AddWeapon(string[] weapons)
        {
            Array.ForEach(weapons, x => Character.Weapons.Add(x));
            return this;
        }

        public IGenericCharacterBuilder SetAge(int age)
        {
            Character.Age = age;
            return this;
        }

        public IGenericCharacterBuilder SetClass(CharacterClasses @class)
        {
            Character.Class = @class;
            return this;
        }

        public IGenericCharacterBuilder SetGender(Gender gender)
        {
            Character.Gender = gender;
            return this;
        }

        public IGenericCharacterBuilder SetName(string name)
        {
            Character.Name = name;
            return this;
        }

        public IGenericCharacterBuilder AddSpell(string spell)
        {
            Character.Spells.Add(spell);
            return this;
        }

        public IGenericCharacterBuilder AddSpell(string[] spells)
        {
            Character.Spells.AddRange(spells);
            return this;
        }

        private bool CanItCastSpells()
        {
            return Character.Class switch
            {
                CharacterClasses.Cleric => true,
                CharacterClasses.Mage => true,
                _ => false
            };
        }
    }
}
