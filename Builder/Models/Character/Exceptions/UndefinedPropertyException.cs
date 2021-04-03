using System;

namespace Builder.Models.Character.Exceptions
{
    public class UndefinedPropertyException : Exception
    {
        public UndefinedPropertyException(string propertyName)
            : base($"Property name: {propertyName}") { }
    }
}
