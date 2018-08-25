using System;

namespace xUnitFluentAssertions.UnitTests
{

    public class MissingPersonNameException : Exception
    {
        public MissingPersonNameException() : base("Name is missing") { }
    }

}