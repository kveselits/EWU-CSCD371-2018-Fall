using System;

namespace UniversityCourse
{
	public class Person
	{
		private string _Name;

		private string _LastName;

		private string _FirstName;

		public string Name
		{
			get
			{
				return FirstName + "." + LastName;
			}
			set
			{
				string[] array = value.Split(".");
				FirstName = array[0];
				LastName = array[1];
			}
		}

		public string LastName
		{
			get
			{
				return _LastName;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				_LastName = value;
			}
		}

		public string Age
		{
			get;
			set;
		}

		public string FirstName
		{
			get
			{
				return _FirstName;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				_FirstName = value;
			}
		}

		public string Id
		{
			get;
			internal set;
		}

		public void Deconstruct(out string firstName, out string lastName)
		{
			firstName = FirstName;
			lastName = LastName;
		}

		public void Deconstruct(out string firstName, out string lastName, out string age)
		{
			Deconstruct(out firstName, out lastName);
			age = Age;
		}

		public Person(string firstName, string lastName)
			: this(firstName, lastName, null)
		{
		}

		public Person(string firstName, string lastName, string age = null)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}
	}
}
