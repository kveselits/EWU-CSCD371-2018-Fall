using System;

namespace UniversityCourse
{
    public static class Extension
    {
        public static string ExtendSummaryInformation(this IEvent extendEvent)
        {
            //Returns GetSummaryInformation in all uppercase.
            string newString = extendEvent.GetSummaryInformation().ToUpper();
            return newString;
        }
    }
}