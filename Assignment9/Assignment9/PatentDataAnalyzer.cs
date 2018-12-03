using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment9
{
    public class PatentDataAnalyzer
    {
        public static List<string> InventorNames()
        {
            return PatentData.Inventors.Select(inventor => inventor.Name).ToList();
        }
        public static List<string> InventorNames(string country)
        {
            if (country == null) throw new ArgumentNullException(nameof(country));
            return PatentData.Inventors
                .Where(inventor => inventor.Country.Equals(country))
                .Select(inventor => inventor.Name)
                .ToList();
        }

        public static List<string> InventorLastNames()
        {
            return PatentData.Inventors
                .OrderByDescending(Id)
                .Select(LastName)
                .ToList();
        }

        private static long Id(Inventor inventor) => inventor.Id;

        private static string LastName(Inventor inventor) => inventor.Name.Split().Last();
    }
}