using System;

namespace UniversityCourse
{
    public class Program
    {
        public static Event NewEvent { get; set; }
        public static Course NewCourse { get; set; }

        private static readonly Program Menu = new Program();

        public static void Main(string[] args)
        {

            bool continueOperation = true; //program exits if false
            do
            {
                continueOperation = StartMenu();
            } while (continueOperation.Equals(true));
        }

        public static bool StartMenu()
        {
            int menuOption;
            do
            {
                menuOption = ObtainSelection();
                if (menuOption.Equals(5))
                {
                    return false;
                }
                switch(menuOption)
                {
                    case 1:
                        NewEvent = CreateEvent();
                        break;
                    case 2:
                        NewCourse = CreateCourse();
                        break;
                    case 3:
                        Console.WriteLine(Application.Display(NewEvent));
                        break;
                    case 4:
                        Console.WriteLine(Application.Display(NewCourse));
                        break;
                    default:
                        return true; //restart program
                }
            } while (!menuOption.Equals(null));
            return true;
        }

        public static Event CreateEvent()
        {
            Console.WriteLine("Please choose a name for the event: ");
            string tempName = Console.ReadLine();
            Console.WriteLine("Please choose a location for the event: ");
            string tempLocation = Console.ReadLine();
            Console.WriteLine("Please choose a start time for the event: ");
            DateTime tempStart = ObtainDateTime();
            Console.WriteLine("Please choose a end time for the event: ");
            DateTime tempEnd = ObtainDateTime();

            return new Event(tempName, tempLocation, tempStart, tempEnd);
        }

        public static Course CreateCourse()
        {
            Console.WriteLine("Please choose a name for the event: ");
            string tempName = Console.ReadLine();
            Console.WriteLine("Please choose a location for the event: ");
            string tempLocation = Console.ReadLine();
            Professor tempProfessor = new Professor("Default", "Professor");
            Console.WriteLine("Please choose a start time for the event: ");
            DateTime tempStart = ObtainDateTime();
            Console.WriteLine("Please choose a end time for the event: ");
            DateTime tempEnd = ObtainDateTime();

            return new Course(tempName, tempLocation, tempProfessor, tempStart, tempEnd);
        }

        public static DateTime ObtainDateTime()
        {
            DateTime tempDateTime;
            do
            {
                Console.WriteLine("Please choose a start time (E.G., MM/DD/YYYY): ");
                string dateString = Console.ReadLine();
                if (DateTime.TryParse(dateString, out tempDateTime))
                {
                    Console.WriteLine($"Date selected: {tempDateTime}{Environment.NewLine}");
                }
                else
                {
                    Console.WriteLine($"Could not parse, invalid date format {dateString}" +
                                      $"Please try again: ");
                }
            } while (tempDateTime.Equals(null));
            return tempDateTime;
        }

        public static int ObtainSelection()
        {
            while(true)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1: Create Event");
                Console.WriteLine("2: Create Course");
                Console.WriteLine("3: Display Events");
                Console.WriteLine("4: Display Courses");
                Console.WriteLine("5: Quit");
                string obtainInput = Console.ReadLine()?.Trim();
                bool validInput = int.TryParse(obtainInput, out int intInput);
                if (validInput.Equals(false) || intInput <= 0 || intInput >= 6)
                {
                    Console.WriteLine("Invalid input, try again");
                }

                return intInput;
            } 
        }
    }
}