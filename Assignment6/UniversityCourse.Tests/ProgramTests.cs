using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UniversityCourse.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Test_IntIsA_Cast()
        {
            int num = 1;
            if (num is int)
                num = 2;
            Assert.AreEqual(2, num);
        }

        [TestMethod]
        public void Test_IntIsA_Failure()
        {
            int num = 0;
            if (num is double)
                num = 1;
            Assert.AreNotEqual(1, num);
        }

        [TestMethod]
        public void Test_Direct_Cast()
        {
            double num = 9000.1; //it's over 9000
            int num2 = (int) num;
            if (num2 is int)
            {
                num2 = 5;
            }

            Assert.AreEqual(5, num2);
        }

        [TestMethod]
        public void Test_AsA_Cast()
        {
            string validateString = "";
            Course newCourse = new Course("CSCD000", "Campus", new Professor("John", "Doe"), DateTime.Today,
                DateTime.Today.AddDays(1));
            Course castCourse = newCourse as Course;
            if (castCourse.Equals(null))
            {
                validateString = "Null";
            }
            else
            {
                validateString = "Not Null";
            }
            Assert.AreEqual("Not Null", validateString);
        }
    }
}