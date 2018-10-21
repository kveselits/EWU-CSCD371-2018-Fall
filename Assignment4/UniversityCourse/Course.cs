using System;
using System.Collections.Generic;

namespace UniversityCourse
{
    public class Course : Event
    {
        private Event _ScheduleItem;
        private static int _CourseInstantiationCount;
        private List<Event> _CourseSchedule;

        public Course(string name, string place, DateTime startTime, DateTime endTime)
            : base(name, place, startTime, endTime)
        {
            ScheduleItem = (Event)this;
            CourseSchedule = new List<Event> {ScheduleItem};
            CourseInstantiationCount++;
        }

        public List<Event> CourseSchedule { get => _CourseSchedule; set => _CourseSchedule = value; }

        public void Add(Event newEvent)
        {
            _CourseSchedule.Add(newEvent);
        }
        public int CourseInstantiationCount { get => _CourseInstantiationCount; set => _CourseInstantiationCount = value; }

        public Event ScheduleItem
        {
            get => _ScheduleItem;
            set
            {
                _ScheduleItem = value;
            }

        }

        public override string GetSummaryInformation()
        {
            string returnString = $"Name of course: {Name}{Environment.NewLine}" +
                                  $"Location of course: {Place}{Environment.NewLine}" +
                                  $"Course Schedule: {Environment.NewLine}";
            foreach (Event scheduleItem in CourseSchedule)
            {
                returnString +=
                    $"{scheduleItem.StartTime.DayOfWeek}: {scheduleItem.StartTime} - {scheduleItem.EndTime}{Environment.NewLine}";
            }
            return returnString;
        }
    }
}
