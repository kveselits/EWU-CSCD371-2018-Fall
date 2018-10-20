using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniversityCourse;

[TestClass]
public class PersonTests
{
    private Person Person
    {
        get;
        set;
    }

    [TestMethod]
    public void Create_Person_Success()
    {
        Person person = new Person("Inigo", "Montoya", "18");
        Assert.AreEqual<string>("Inigo", person.FirstName);
        Assert.AreEqual<string>("Montoya", person.LastName);
        Assert.AreEqual<string>("Inigo.Montoya", person.Name);
    }

    [TestMethod]
    [TestInitialize]
    public void setup()
    {
        Application.RegisteredPeopleIds.Clear();
        Person person = new Person("Inigo", "Montoya", "18");
    }

    public void UserName_ChangeName_Success()
    {
        Person.FirstName = "Frank";
        Assert.AreEqual<string>("Frank", Person.FirstName);
        Person.LastName = "Nelson";
        Assert.AreEqual<string>("Nelson", Person.LastName);
    }

    [TestMethod]
    public void Deconstruct_Returns_FirstName_LastName()
    {
        Person person = new Person("Inigo", "Montoya");
        person.Deconstruct(out string firstName, out string lastName);
        string text = firstName;
        string text2 = lastName;
        Assert.AreEqual<string>("Inigo", text);
        Assert.AreEqual<string>("Montoya", text2);
    }

    [TestMethod]
    public void Foo()
    {
        Person person = new Person("Inigo", "Montoya");
        string firstName = person.FirstName;
        string lastName = person.LastName;
        Assert.AreEqual<string>("Inigo", firstName);
    }

    [TestMethod]
    public void PatternMatching()
    {
        Person person = new Employee("Kevin", "Bost", "42");
        Type type = person.GetType();
        Person person2 = person;
        if (person2 != null)
        {
        }
        Person person3;
        if ((person3 = person) != null)
        {
            Assert.IsTrue(person == person3);
            Assert.AreEqual<string>("Kevin", person3.FirstName);
        }
        Person person4 = person;
        Person person5 = person4;
        if (person5 != null)
        {
            person5 = person5;
            Person person6 = person5;
            if (!(person6.FirstName == "Kevin"))
            {
                Employee employee;
                if ((employee = (person5 as Employee)) != null)
                {
                    Employee employee2 = employee;
                    Assert.AreEqual<string>("42", employee2.ID);
                }
            }
            else
            {
                Assert.AreEqual<string>("Bost", person6.LastName);
            }
        }
    }

    [TestMethod]
    public void Test_Switch_Statement_Given_An_Object_Returns_Derived_Implimentation()
    {
        Person person = new Person("Inigo", "Montoya", "123");
        int num = Application.Register(person);
        Person person2 = new Person("Blahk", "blah", "one");
        int num2 = Application.Register(person2);
        Assert.AreEqual<int>(1, num);
        Assert.AreEqual<int>(2, num2);
    }

    [TestCleanup]
    public void CleanupTest()
    {
    }

    [TestMethod]
    public void Test_Register_With_Employee()
    {
        Application.RegisteredPeopleIds.Clear();
        Person person = new Employee("S", "4", "blah");
        int num = Application.Register(person);
        Assert.AreEqual<int>(1, num);
    }
}