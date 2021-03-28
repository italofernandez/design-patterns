namespace Builder.Models.Character.Builders
{
    public class CharacterBuilder : ICharacterBuilder
    {
        public Character Product { get; set; }

        public CharacterBuilder() => this.Reset();

        public ICharacterBuilder AddWeapon(string[] weapons)
        {
            Product.Weapons = weapons;
            return this;
        }

        public Character Build() => Product;

        public void Reset()
        {
            Product = new Character();
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
