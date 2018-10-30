using System;

namespace UniversityCourse
{
    public class Program : IConsole
    {
        private static Event _NewEvent;

        public static Event NewEvent { get => _NewEvent; set => _NewEvent = value; }

        public static void Main(string[] args)
        {
            bool continueOperation = true; //program exits if false
            do
            {
                continueOperation = StartMenu();
            } while (continueOperation.Equals(true));
        }

        private static bool StartMenu()
        {
            char menuOption;
            do
            {
                menuOption = ObtainSelection();
                if (menuOption.Equals('3'))
                {
                    return false;
                }
                switch(menuOption)
                {
                    case '1':
                        NewEvent = CreateEvent();
                        break;
                    case '2':
                        Console.WriteLine(NewEvent.GetSummaryInformation());
                        break;
                    default:
                        return true; //restart program
                }
            } while (!menuOption.Equals(null));
            return true;

        }

        private static Event CreateEvent()
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

        private static DateTime ObtainDateTime()
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

        private static char ObtainSelection()
        {
            char obtainInput;
            do
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1: Create Event");
                Console.WriteLine("2: Display Events");
                Console.WriteLine("3: Quit");
                obtainInput = Console.ReadKey(true).KeyChar;
            } while (!(obtainInput.Equals('1')) && !(obtainInput.Equals('2')) &&
                     !(obtainInput.Equals('3')));
            return obtainInput;
        }

        public void Write(string line)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }

        public string ReadLine()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}