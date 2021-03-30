using System;

namespace Builder.Models.Character.Builders
{
    public class MageCharacterBuilder : ICharacterBuilder
    {
        public Character Product { get; set; }

        public Character Build()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public ICharacterBuilder AddSpell(string spellName)
        {
            throw new NotImplementedException();
        }

        public ICharacterBuilder SetName(string name)
        {
            throw new NotImplementedException();
        }

        public ICharacterBuilder SetAge(int age)
        {
            throw new NotImplementedException();
        }

        public ICharacterBuilder SetClass(CharacterClasses @class)
        {
            throw new NotImplementedException();
        }

        public ICharacterBuilder SetGender(Gender gender)
        {
            throw new NotImplementedException();
        }

        public ICharacterBuilder AddWeapon(string[] weapons)
        {
            throw new NotImplementedException();
        }

        public ICharacterBuilder AddWeapon(string weapon)
        {
            throw new NotImplementedException();
        }
    }
}
