using System;

namespace xUnitFluentAssertions.UnitTests
{

    public class Person
    {
        public string Name { private get; set; }
        public int Age { private get; set; }

        public Person(string name, int age)
        {
            if (age < 18) throw new WrongPersonAgeException(age);

            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(this.Name))
                throw new MissingPersonNameException();

            return $"Hi {this.Name}!";
        }

        public string GetName() => this.Name;
        public int GetAge() => this.Age;
    }

}