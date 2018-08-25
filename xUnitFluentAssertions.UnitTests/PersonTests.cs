using FluentAssertions;
using System;
using Xunit;

namespace xUnitFluentAssertions.UnitTests
{

    public class PersonTests
    {
        private readonly string _name = "Jorge";
        private readonly int _age = 18;

        [Fact]
        public void Person_WithConstructorValues_ShouldBeNameAsExpected()
        {
            // Arrange
            var person = new Person(this._name, this._age);
            // Act
            var personName = person.GetName();
            // Assert
            personName.Should().Be(this._name);
        }

        [Fact]
        public void Person_WithConstructorValues_ShouldBeAgeAsExpected()
        {
            // Arrange
            var person = new Person(this._name, this._age);
            // Act
            var personAge = person.GetAge();
            // Assert
            personAge.Should().Be(this._age);
        }

        [Fact]
        public void Person_WithConstructorValuesAndUsingToString_ShouldBeAsExpected()
        {
            // Arrange
            var person = new Person(this._name, this._age);
            // Act
            var personToString = person.ToString();
            // Assert
            personToString.Should().StartWith("Hi").And.EndWith("!").And.Contain(this._name).And.ContainAll($"Hi {this._name}!");
        }

        [Fact]
        public void Person_WithMissingName_ShouldReturnsAnException()
        {
            // Arrange
            var person = new Person(String.Empty, this._age);
            // Act
            Action action = () => person.ToString();
            // Assert
            action.Should().Throw<MissingPersonNameException>().WithMessage("Name is missing");
        }

        [Fact]
        public void Person_WithWrongAge_ShouldReturnsAnException()
        {
            // Arrange & Act
            var age = 17;
            Action action = () => new Person(String.Empty, age);
            // Assert
            action.Should().Throw<WrongPersonAgeException>().WithMessage($"Age {age} is invalid. Should be greater than 18.");
        }

    }

}