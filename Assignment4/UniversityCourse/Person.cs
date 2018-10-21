using System;

namespace UniversityCourse
{
    public class Person
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Name
        {
            get => $"{FirstName} {LastName}";
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(Name));
                }

                string[] ara = value.Split(" ");
                FirstName = ara[0];
                LastName = ara[1];
            }
        }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string firstName, string lastName)
        {
            Name = $"{firstName} {lastName}";
        }

    }
}