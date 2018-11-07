using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UniversityCourse.Scheduler;

namespace UniversityCourse.Tests
{
    [TestClass]
    public class SchedulerTests
    {
        public Time NewTime { get; private set; }
        public Time NewTime2 { get; set; }
        public Schedule TestSchedule { get; private set; }
        public Schedule TestSchedule2 { get; private set; }
        public Schedule TestSchedule3 { get; private set; }

        [TestInitialize]
        public void Test_Initialize()
        {
            NewTime = new Time(12, 30, 0);
            TestSchedule = new Schedule("tuesday", "fall", NewTime, new TimeSpan(0, 12, 30, 0));
            TestSchedule2 = new Schedule("tuesday thursday friday", "winter", NewTime, new TimeSpan(0, 8, 0, 0));
            NewTime2 = new Time(1, 0, 0);
            TestSchedule3 = new Schedule("saturday sunday wednesday monday", "spring", NewTime, new TimeSpan(0, 8, 0, 0));
        }

        [TestMethod]
        public void Test_Size_Schedule()
        {
            int structSize = Marshal.SizeOf(TestSchedule);
            bool rightSize = structSize <= 16;
            Console.WriteLine(structSize);
            Assert.IsTrue(rightSize);
        }
        [TestMethod]
        public void Test_Size_Time()
        {
            int structSize = Marshal.SizeOf(NewTime);
            bool rightSize = structSize <= 16;
            Console.WriteLine(structSize);
            Assert.IsTrue(rightSize);
        }

        [TestMethod]
        public void Test_Valid_Single_Day()
        {
            Assert.AreEqual("tuesday", TestSchedule.DayOfWeek.ToString().ToLower());
        }

        [TestMethod]
        public void Test_Valid_Multiple_Days()
        {
            Assert.AreEqual("tuesday, thursday, friday", TestSchedule2.DayOfWeek.ToString().ToLower());

        }
        [TestMethod]
        public void Test_Valid_Multiple_Days_New_Time_Struct()
        {
            Assert.AreEqual("sunday, monday, wednesday, saturday", TestSchedule3.DayOfWeek.ToString().ToLower());

        }
        [TestMethod]
        public void Test_Valid_Multiple_Days_New_Time_Original_Unchanged()
        {
            Assert.AreEqual("12:30:0", NewTime.ToString());

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Invalid_Days()
        {
            Schedule testScheduleError = new Schedule("cows", "fall", NewTime, new TimeSpan(0, 12, 30, 0));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Valid_Invalid_Term()
        {
            Schedule testScheduleError = new Schedule("monday", "not-fall", NewTime, new TimeSpan(0, 12, 30, 0));
            Assert.AreEqual("tuesday, thursday, friday", TestSchedule2.DayOfWeek.ToString().ToLower());

        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_Valid_Invalid_Null_Day()
        {
            Schedule testScheduleError = new Schedule(null, "not-fall", NewTime, new TimeSpan(0, 12, 30, 0));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Valid_Invalid_Null_Quarter()
        {
            Schedule testScheduleError = new Schedule("monday", null, NewTime, new TimeSpan(0, 12, 30, 0));
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_Valid_Invalid_Null_Time()
        {
            int? nullInt = new int?();
            Time newTime2 = new Time((int)nullInt, (int)nullInt, (int)nullInt);
        }
    }
}