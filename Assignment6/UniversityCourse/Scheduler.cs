using System;

namespace UniversityCourse
{
    public class Scheduler
    {

        public static Time _Time;
        public static TimeSpan _Duration;

        [Flags]
        public enum DaysOfWeek : byte
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

        private static DaysOfWeek ParseString(string value)
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

        private static QuarterOfYear ParseStringQuarter(string value)
        {
            switch (value?.ToLower()?.Trim())
            {
                case "spring":
                    return QuarterOfYear.Spring;
                case "summer":
                    return QuarterOfYear.Summer;
                case "fall":
                    return QuarterOfYear.Fall;
                case "winter":
                    return QuarterOfYear.Winter;
                default:
                    throw new ArgumentException(($"Not a valid quarter term: \"{value?.ToString()}\""));
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

            public override string ToString()
            {
                return $"{Hours}:{Minutes}:{Seconds}";
            }
        }

        public readonly struct Schedule
        {
            public Schedule(string dayOfWeek, string quarterOfYear, Time startTime, TimeSpan duration)
            {
                DayOfWeek = ParseString(dayOfWeek);
                Quarter = ParseStringQuarter(quarterOfYear);
                StartTime = startTime;
                Duration = duration;
            }
            public DaysOfWeek DayOfWeek { get; }
            public QuarterOfYear Quarter { get; }

            public Time StartTime
            {
                get => _Time;
                set => _Time = value;
            }

            public TimeSpan Duration
            {
                get => _Duration;
                set => _Duration = value;
            }
        }
        public static void Main(string[] args)
        {

        }
    }
}
