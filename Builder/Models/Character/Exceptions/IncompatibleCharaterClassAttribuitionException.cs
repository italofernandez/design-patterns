using System;

namespace Builder.Models.Character.Exceptions
{
    public class IncompatibleCharaterClassAttribuitionException : Exception
    {
        public IncompatibleCharaterClassAttribuitionException() 
            : base("Only Clerics and Mages can cast spells!") { }
    }
}
