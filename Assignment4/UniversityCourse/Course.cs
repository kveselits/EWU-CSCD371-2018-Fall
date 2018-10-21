using System;
using System.Collections.Generic;

namespace UniversityCourse
{
    public class Course : Event
    {
        private static int _CourseInstantiationCount;
        private List<Event> _CourseSchedule;
        private List<Person> _StudentRoster;
        private Professor _ProfessorName;

        public Course(string name, string place, Professor professorName, DateTime startTime, DateTime endTime)
            : base(name, place, startTime, endTime)
        {
            ProfessorName = professorName;
            ScheduleItem = (Event)this;
            CourseSchedule = new List<Event> { ScheduleItem };
            StudentRoster = new List<Person>();
            CourseInstantiationCount++;
            UniversityName = "Eastern Washington University";
        }

        public string UniversityName { get; }

        public Professor ProfessorName { get => _ProfessorName; set => _ProfessorName = value; }
        public List<Event> CourseSchedule { get => _CourseSchedule; set => _CourseSchedule = value; }
        public List<Person> StudentRoster { get => _StudentRoster; set => _StudentRoster = value; }
        public int CourseInstantiationCount { get => _CourseInstantiationCount; set => _CourseInstantiationCount = value; }

        public void Add(Event newEvent)
        {
            CourseSchedule.Add(newEvent);
        }

        public void AddPerson(Person newPerson)
        {
            StudentRoster.Add(newPerson);
        }

        public Event ScheduleItem { get; set; }

        public override string GetSummaryInformation()
        {
            string returnString = $"Name of course: {Name}{Environment.NewLine}" +
                                  $"Name of Professor: {ProfessorName.Name}{Environment.NewLine}" +
                                  $"Location of course: {Place}{Environment.NewLine}" +
                                  $"{Environment.NewLine}Course Schedule: {Environment.NewLine}";
            foreach (Event scheduleItem in CourseSchedule)
            {
                returnString +=
                    $"{scheduleItem.StartTime.DayOfWeek}: {scheduleItem.StartTime} - " +
                    $"{scheduleItem.EndTime}{Environment.NewLine}";
            }
        
            if (StudentRoster.Count > 0)
                returnString += $"{Environment.NewLine}Student Roster: ";
            {
                foreach (Person student in StudentRoster)
                {
                    returnString += $"{student.Name}{Environment.NewLine}";
                }
            }
            return returnString;
        }
    }
}
