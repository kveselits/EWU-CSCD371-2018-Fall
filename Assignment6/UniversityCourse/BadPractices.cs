using System;

namespace UniversityCourse
{
    public class BadCar
    {
        public BadCar(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public void BadMethod(BadCar car)
        {
            car.Make = "Ford";
            car.Model = "Pinto";
        }
        public void BadMethodNew(ref BadCar newCar)
        {
            BadCar betterCar = new BadCar("Dodge", "Viper");
            newCar = betterCar;
        }
    }
    public struct BadPerson : BadPerson.IBadInterface
    {
        public BadPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public void BadMethod(BadPerson person)
        {
            person.Name = "Stalin";
            person.Age = 0;
        }
        public void BadMethod(ref BadPerson person)
        {
            person.Name = "Stalin";
            person.Age = 0;
        }
        public static void BadInterfaceMethod(IBadInterface person)
        {
            person.Name = "Stalin";
            person.Age = 0;
        }

        public interface IBadInterface
        {
            string Name { get; set; }
            int Age { get; set; }
        }
    }
}