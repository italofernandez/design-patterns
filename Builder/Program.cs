using Builder.Models.Character.Builders;
using Builder.Models.Character.Enums;
using Builder.Models.ConnectionString;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildCharactersExample();
            Console.WriteLine();
            BuildConnectionStringExample();            
        }

        static void BuildCharactersExample()
        {
            //We can use the same 'build API' to build different types of characters
            Console.WriteLine("Character examples ====================");

            var genericCharacter = new GenericCharacterBuilder()
                .SetName("Kruger")
                .SetClass(CharacterClasses.Mage)
                .AddWeapon("Long Spear")
                .AddWeapon("Two hands Sword")
                .AddSpell("Heal")
                .Build();

            var mageCharacter = new MageCharacterBuilder()
                .SetName("Strix")
                .SetGender(Gender.Female)
                .Build();

            Console.WriteLine("# Character 1");
            Console.WriteLine(genericCharacter);

            Console.WriteLine("\n# Character 2");
            Console.WriteLine(mageCharacter);
        }

        static void BuildConnectionStringExample()
        {
            //We can use the same 'build API' to build different types of connection strings
            Console.WriteLine("Connection string examples ============\n");

            Console.WriteLine("# MSSQL Server Connection String");
            var microsoftSqlConnectionString = new MSSqlConnectionStringBuilder()
                .TrustedConnection(true)
                .WithServerAddress("192.168.0.12")
                .WithCredentials(username: "root", password: "123")
                .WithPort("9999")
                .WithDatabaseName("")
                .Build();

            Console.WriteLine(microsoftSqlConnectionString);

            Console.WriteLine("\n# MongoDB Connection String");
            var mongoDbConnectionString = new MongoDbConnectionStringBuilder()
                .WithServerAddress("192.168.0.12")
                .WithPort("9999")
                .WithCredentials(username: "root", password: "123")
                .WithDatabaseName("mongo_dev")
                .Build();

            Console.WriteLine(mongoDbConnectionString);
        }
    }
}
