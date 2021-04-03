using Builder.Models.Character.Builders.Interfaces;
using Builder.Models.Character.Enums;

namespace Builder.Models.Character.Builders
{
    public class MageCharacterBuilder : IMageCharacterBuilder
    {
        private Character Character;

        public MageCharacterBuilder()
            => Reset();

        public Character Build()
        {
            Character.Class = CharacterClasses.Mage;
            return Character;
        }

        public void Reset() 
            => Character = new Character();

        public IMageCharacterBuilder AddSpell(string spell)
        {
            if(!string.IsNullOrEmpty(spell))
                Character.Spells.Add(spell);
            return this;
        }

        public IMageCharacterBuilder AddSpell(string[] spells)
        {
            if (spells.Length > 0)
                Character.Spells.AddRange(spells);
            return this;
        }

        public IMageCharacterBuilder SetAge(int age)
        {
            Character.Age = age;
            return this;
        }

        public IMageCharacterBuilder SetGender(Gender gender)
        {
            Character.Gender = gender;
            return this;
        }

        public IMageCharacterBuilder SetName(string name)
        {
            Character.Name = name;
            return this;
        }
    }
}
