using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityCourse.Tests
{

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void Test_Add_New_Course()
        {
            Course newCourse = new Course("jap", "CRB", DateTime.UtcNow, DateTime.Now);
        }
    }
}