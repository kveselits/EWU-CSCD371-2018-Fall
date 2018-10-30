using System;
using System.Collections.Generic;

namespace UniversityCourse
{
    public class Event : IEvent
    {
        private string _Name;
        private string _Place;
        private DateTime _StartTime;
        private DateTime _EndTime;
        private static int _InstantiationCount;

        public Event(string name, string place, DateTime startTime, DateTime endTime)
        {
            Name = name;
            Place = place;
            StartTime = startTime;
            EndTime = endTime;
            EventList.Add(this);
            InstantiationCount++;
        }

        public static List<Event> EventList { get; } = new List<Event>();

        public Event(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public int InstantiationCount { get => _InstantiationCount; set => _InstantiationCount = value; }

        public string Place { get => _Place; set => _Place = value; }

        public string Name { get => _Name; set => _Name = value; }
        public DateTime StartTime { get => _StartTime; set => _StartTime = value; }

        public DateTime EndTime
        {
            get => _EndTime;
            set
            {
                if (value.CompareTo(_StartTime) < 0)
                {
                    throw new ArgumentOutOfRangeException($"End date cannot be before start date: " +
                                                          $"{nameof(value)}");
                }
                _EndTime = value;
            }

        }

        public virtual string GetSummaryInformation()
        {
            string returnString = "";
            foreach (Event eventItem in EventList)
            {
                returnString += $"{Environment.NewLine}Name of event: {eventItem.Name}{Environment.NewLine}" +
                               $"Location of event {eventItem.Place}{Environment.NewLine}" +
                               $"Start time: {eventItem.StartTime}{Environment.NewLine}" +
                               $"End time: {eventItem.EndTime}{Environment.NewLine}";
            }
            return returnString;
        }
    }
}
