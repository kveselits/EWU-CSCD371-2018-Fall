using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniversityCourse;

[TestClass]
public class PersonTests
{
    private Person Person { get; set; }

    [TestMethod]
    public void Create_Person_Success()
    {
        Person person = new Person("John", "Doe");
        Assert.AreEqual<string>("John", person.FirstName);
        Assert.AreEqual<string>("Doe", person.LastName);
        Assert.AreEqual<string>("John Doe", person.Name);
    }

    [TestMethod]
    [TestInitialize]
    public void setup()
    {
        Person person = new Person("John", "Doe");
    }

    public void UserName_ChangeName_Success()
    {
        Person.FirstName = "Kris";
        Assert.AreEqual<string>("Kris", Person.FirstName);
        Person.LastName = "Veselits";
        Assert.AreEqual<string>("Veselits", Person.LastName);
    }

    [TestMethod]
    public void Deconstruct_Returns_FirstName_LastName()
    {
        Person person = new Person("John", "Doe");
        person.Deconstruct(out string firstName, out string lastName);
        string text = firstName;
        string text2 = lastName;
        Assert.AreEqual<string>("John", text);
        Assert.AreEqual<string>("Doe", text2);
    }

    [TestMethod]
    public void Test_Names_Are_Equal()
    {
        Person person = new Person("John", "Doe");
        string firstName = person.FirstName;
        string lastName = person.LastName;
        Assert.AreEqual<string>("John", firstName);
    }

    [TestCleanup]
    public void CleanupTest()
    {
    }
}