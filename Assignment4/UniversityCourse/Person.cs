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
                (FirstName, LastName) = ParseName(value);
            }
        }

        private (string FirstName, string LastName) ParseName(string value)
        {
            int separatorIndex = value.IndexOf(' ');
            if (separatorIndex < 2 || separatorIndex > value.Length - 2)
            {
                throw new ArgumentException(nameof(Name),
                    "Name must be of the format <FirstName>.<LastName>");
            }
            else
            {
                return (FirstName: value.Substring(0, separatorIndex),
                    LastName: value.Substring(separatorIndex + 1,
                    value.Length - separatorIndex - 1));
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