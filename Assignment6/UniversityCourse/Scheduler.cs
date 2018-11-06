
using System;

namespace UniversityCourse
{
    public class Scheduler
    {
        [Flags]
        public enum DaysOfWeek
        {
            Sunday = 1,         //1  0000001
            Monday = 1 << 1,    //2  0000010
            Tuesday = 1 << 2,   //4  0000100
            Wednesday = 1 << 3, //8  0001000
            Thursday = 1 << 4,  //16 0010000
            Friday = 1 << 5,    //32 0100000
            Saturday = 1 << 6,  //64 1000000
        }
        public enum QuarterOfYear
        {
            Spring,
            Summer,
            Fall,
            Winter,
        }

        public static DaysOfWeek ParseString(string value)
        {
            string[] daysArray = value.Split(' ');

            if (daysArray.Length == 0)
            {
                throw new ArgumentException("Bad input");
            }
            else if (daysArray.Length == 1)
            {
                return ParseDays(value);
            }
            else
            {
                DaysOfWeek days = 0;
                foreach (string item in daysArray)
                {
                    days |= ParseDays(item);
                }
                return days;
            }
        }

        private static DaysOfWeek ParseDays(string value)
        {
            switch (value?.ToLower())
            {
            case "monday":
                return DaysOfWeek.Monday;
            case "tuesday":
                return DaysOfWeek.Tuesday;
            case "wednesday":
                return DaysOfWeek.Wednesday;
            case "thursday":
                return DaysOfWeek.Thursday;
            case "friday":
                return DaysOfWeek.Friday;
            case "saturday":
                return DaysOfWeek.Saturday;
            case "sunday":
                return DaysOfWeek.Sunday;
            default:
                throw new ArgumentException("Invalid input");
            }
        }

        public readonly struct Time
        {
            public Time(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }

            public int Seconds { get; }

            public int Minutes { get; }

            public int Hours { get; }
        };
        public struct Schedule
        {
            private DaysOfWeek _DayOfWeek;
            private QuarterOfYear _Quarter;

            public Schedule(string dayOfWeek, string quarterOfYear, Time startTime, TimeSpan duration) : this()
            {
                DayOfWeek = dayOfWeek;
                Quarter = quarterOfYear;
                StartTime = startTime;
                Duration = duration;
            }

            public string Quarter
            {
                get => _Quarter.ToString();

            set
            {
                switch (value?.ToLower()?.Trim())
                {
                        case "spring":
                            _Quarter = QuarterOfYear.Spring;
                            break;
                        case "summer":
                            _Quarter = QuarterOfYear.Summer;
                            break;
                        case "fall":
                            _Quarter = QuarterOfYear.Fall;
                            break;
                        case "winter":
                            _Quarter = QuarterOfYear.Winter;
                            break;
                        default:
                            throw new ArgumentException(($"Not a valid quarter term: \"{value?.ToString()}\""));
                }
            }
            }
            public string DayOfWeek
            {
                get => _DayOfWeek.ToString();
                set => _DayOfWeek = ParseString(value);
            }

            public Time StartTime { get; set; }
            public TimeSpan Duration { get; set; }
        };
    }
}