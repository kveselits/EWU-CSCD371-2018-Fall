using System;

namespace UniversityCourse
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			DateTime[] array = new DateTime[7];
			Event @event = new Event("monday", "12");
			Console.WriteLine(@event.ToString());
		}
	}
}
