using Builder.Models.Character.Enums;

namespace Builder.Models.Character.Builders.Interfaces
{
    public interface IGenericCharacterBuilder : IBuilder<Character>
    {
        IGenericCharacterBuilder SetName(string name);
        IGenericCharacterBuilder SetAge(int age);
        IGenericCharacterBuilder SetClass(CharacterClasses @class);
        IGenericCharacterBuilder SetGender(Gender gender);
        IGenericCharacterBuilder AddWeapon(string weapon);
        IGenericCharacterBuilder AddWeapon(string[] weapons);
        IGenericCharacterBuilder AddSpell(string spell);
        IGenericCharacterBuilder AddSpell(string[] spells);
    }
}
