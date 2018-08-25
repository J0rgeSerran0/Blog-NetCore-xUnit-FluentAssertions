using System;

namespace xUnitFluentAssertions.UnitTests
{

    public class WrongPersonAgeException : Exception
    {
        public WrongPersonAgeException(int age) : base($"Age {age} is invalid. Should be greater than 18.") { }
    }

}