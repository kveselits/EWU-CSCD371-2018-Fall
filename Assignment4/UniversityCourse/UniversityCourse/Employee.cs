namespace UniversityCourse
{
	public class Employee : Person
	{
		public string ID
		{
			get;
		}

		public Employee(string firstName, string lastName, string id)
			: base(firstName, lastName, id)
		{
		}
	}
}
