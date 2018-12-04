using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment9
{
    public class PatentDataAnalyzer
    {
        /// <summary>
        /// Retrieve inventor Id.
        /// </summary>
        private static long Id(Inventor inventor) => inventor.Id;

        /// <summary>
        /// Split at spaces within name, and retrieve last element.
        /// </summary>
        private static string LastName(Inventor inventor) => inventor.Name.Split().Last();

        /// <summary>
        /// Concatenate inventor's state and country abbreviation with a dash.
        /// </summary>
        private static string StateCountry(Inventor inventor) => $"{inventor.State}-{inventor.Country}";

        public static List<string> InventorNames()
        {
            return PatentData.Inventors.Select(inventor => inventor.Name).ToList();
        }
        public static List<string> InventorNames(string country)
        {
            if (country is null) throw new ArgumentNullException(nameof(country));
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

        public static string LocationsWithInventors()
        {
            return string.Join(",", PatentData.Inventors.Select(StateCountry).Distinct());
        }
    }
}