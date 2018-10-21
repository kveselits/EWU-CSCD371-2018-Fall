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

    [TestMethod]
    public void PatternMatching()
    {
        Person person = new Professor("Kris", "Veselits");
        Type type = person.GetType();
        Person person2 = person;
        if (person2 != null)
        {
        }

        Person person3;
        if ((person3 = person) != null)
        {
            Assert.IsTrue(person == person3);
            Assert.AreEqual<string>("Kris", person3.FirstName);
        }

        Person person4 = person;
        Person person5 = person4;
        if (person5 != null)
        {
            person5 = person5;
            Person person6 = person5;
            if (!(person6.FirstName == "Kris"))
            {
                Professor professor;
                if ((professor = (person5 as Professor)) != null)
                {
                    Professor professor2 = professor;
                    Assert.AreEqual<string>("42", professor2.Id);
                }
            }
            else
            {
                Assert.AreEqual<string>("Veselits", person6.LastName);
            }
        }
    }

    [TestCleanup]
    public void CleanupTest()
    {
    }
}