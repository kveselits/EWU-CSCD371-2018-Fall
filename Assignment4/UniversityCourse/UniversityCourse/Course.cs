using System;

namespace UniversityCourse
{
	public class Course : Meeting
	{
		public override string _Name
		{
			get;
			set;
		}

		public Course()
		{
		}

		public Course(DateTime[] schedule, string name)
			: base(schedule, name)
		{
		}
	}
}
