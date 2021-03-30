using System;

namespace Builder.Models.Character.Builders
{
    public class CharacterBuilder : ICharacterBuilder
    {
        private Character Product;

        public CharacterBuilder()
            => this.Reset();

        public Character Build()
            => Product;

        public void Reset()
            => Product = new Character();

        public ICharacterBuilder AddWeapon(string weapon)
        {
            Product.Weapons.Add(weapon);
            return this;
        }

        public ICharacterBuilder AddWeapon(string[] weapons)
        {
            Array.ForEach(weapons, x => Product.Weapons.Add(x));
            return this;
        }

        public ICharacterBuilder SetAge(int age)
        {
            Product.Age = age;
            return this;
        }

        public ICharacterBuilder SetClass(CharacterClasses @class)
        {
            Product.Class = @class;
            return this;
        }

        public ICharacterBuilder SetGender(Gender gender)
        {
            Product.Gender = gender;
            return this;
        }

        public ICharacterBuilder SetName(string name)
        {
            Product.Name = name;
            return this;
        }
    }
}
