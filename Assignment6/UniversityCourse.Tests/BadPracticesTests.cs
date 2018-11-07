using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UniversityCourse.Scheduler;

namespace UniversityCourse.Tests
{
    [TestClass]
    public class BadPracticesTests
    {
        [TestMethod]
        public void Passing_Struct_To_Method_Not_Changed_In_Original_Method()
        {
            BadPerson testPerson = new BadPerson("John", 18);
            testPerson.BadMethod(testPerson);
            Assert.AreNotEqual("Stalin", testPerson.Name);
            Assert.AreNotEqual(0, testPerson.Age);
        }
        [TestMethod]
        public void Passing_Class_To_Method_Is_Changed_In_Original_Method()
        {
            BadCar testCar = new BadCar("Toyota", "Prius");
            testCar.BadMethod(testCar);
            Assert.AreEqual("Ford", testCar.Make);
            Assert.AreEqual("Pinto", testCar.Model);
        }
        public void Passing_Struct_To_Method_Is_Changed_In_Original_Method()
        {
            BadPerson testPerson = new BadPerson("John", 18);
            testPerson.BadMethod(ref testPerson);
            Assert.AreEqual("Stalin", testPerson.Name);
            Assert.AreEqual(0, testPerson.Age);
        }
        [TestMethod]
        public void Passing_Class_To_Method_Is_Changed_In_Original_Method_New_Instance()
        {
            BadCar testCar = new BadCar("Toyota", "Prius");
            testCar.BadMethodNew(ref testCar);
            Assert.AreNotEqual("Toyota", testCar.Make);
            Assert.AreNotEqual("Prius", testCar.Model);
            Assert.AreEqual("Dodge", testCar.Make);
            Assert.AreEqual("Viper", testCar.Model);
        }
        [TestMethod]
        public void Passing_Interface_To_Method_Is_Changed_In_Original_Method()
        {
            BadPerson testPerson = new BadPerson("John", 18);
            var iPerson = testPerson as BadPerson.IBadInterface;
            BadPerson.BadInterfaceMethod(iPerson);
            Assert.AreEqual("Stalin", iPerson.Name);
            Assert.AreEqual(0, iPerson.Age);
        }
    }
}