using Builder.Models.Character.Enums;

namespace Builder.Models.Character.Builders.Interfaces
{
    public interface IMageCharacterBuilder : IBuilder<Character>
    {
        IMageCharacterBuilder SetName(string name);
        IMageCharacterBuilder SetAge(int age);
        IMageCharacterBuilder SetGender(Gender gender);
        IMageCharacterBuilder AddSpell(string spell);
        IMageCharacterBuilder AddSpell(string[] spells);
    }
}
