using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment9
{
    public class PatentDataAnalyzer
    {
        public static List<string> InventorNames(string country)
        {
            return PatentData.Inventors
                .Where(inventor => inventor.Country.Equals(country))
                .Select(inventor => inventor.Name)
                .ToList();
        }
    }
}