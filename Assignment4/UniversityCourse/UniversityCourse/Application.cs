using System.Collections.Generic;

namespace UniversityCourse
{
	public class Application
	{
		private static Person[] credentials = new Person[2]
		{
			new Person("Inigo", "Montoya", "password"),
			new Person("Princess", "Buttercup", "AnybodyWantAPeanut")
		};

		public static List<string> RegisteredPeopleIds
		{
			get;
		} = new List<string>();


		public static bool Login(string userName, string password)
		{
			Person[] array = credentials;
			foreach (Person person in array)
			{
			}
			return true;
		}

		public static int Register(Person person)
		{
			RegisteredPeopleIds.Add(person.Id);
			return RegisteredPeopleIds.Count;
		}
	}
}
