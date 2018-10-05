using System;
using System.Text.RegularExpressions;

namespace Assignment2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a mathematical operation: ");
            string expression = Console.ReadLine();
            string pattern = @"(-?(0|[1-9]\d*)(\.\d+)?)([+-/*])(-?(0|[1-9]\d*)(\.\d+)?)"; //Referenced for regex pattern: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            foreach (Match m in Regex.Matches(expression, pattern)) //referenced https://www.regextester.com/
            {
                if (decimal.TryParse(m.Groups[1].Value, out var num1))
                    if (decimal.TryParse(m.Groups[5].Value, out var num2))
                        switch (m.Groups[4].Value)
                        {
                            case "+":
                                Console.WriteLine(num1 + num2);
                                break;
                            case "-":
                                Console.WriteLine(num1 - num2);
                                break;
                            case "*":
                                Console.WriteLine(num1 * num2);
                                break;
                            case "/":
                                if (num2 == 0) //Panic!
                                {
                                    Console.WriteLine("Error: division by zero not allowed.");
                                    break;
                                }
                                Console.WriteLine(num1 / num2);
                                break;
                        }
            }
        }
    }
}
