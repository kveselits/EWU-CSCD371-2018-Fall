using System;

namespace Assignment2
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //Referenced:
            int i = 1;
            string expression = "";
            while (i.Equals(1))
            {
               i = PerformOperation(i, expression);
            }
        }

        public static int PerformOperation(int i, string expression)
        {
            try
            {
          
                Console.WriteLine("Please enter a mathematical operation. E.G., (1+3): ");
                Console.WriteLine("Type quit, or q to exit the program");
                expression = Console.ReadLine().ToLower();
                if (expression.Equals("quit") || expression.Equals("q"))
                {
                    return 0;
                }
                else
                {
                    //Referenced: https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable.compute
                    string value = new System.Data.DataTable().Compute(expression, null).ToString();
                    Console.WriteLine($"{value} {Environment.NewLine}");
                    return 1;
                }

            }
            catch (Exception)
            {
                Exception e = new Exception();
                Console.WriteLine($"Not a valid mathematical expression: \"{expression}\" {e} {Environment.NewLine}");
                return 1;
            }
        }
    }
}