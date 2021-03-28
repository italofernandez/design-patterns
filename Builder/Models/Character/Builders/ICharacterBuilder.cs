namespace Builder.Models.Character.Builders
{
    public interface ICharacterBuilder : IBuilder<Character>
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetAge(int age);
        ICharacterBuilder SetClass(CharacterClasses @class);
        ICharacterBuilder SetGender(Gender gender);
        ICharacterBuilder AddWeapon(string[] weapons);
    }
}
