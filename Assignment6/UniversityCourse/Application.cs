using System;

namespace UniversityCourse
{
    public static class Application
    {
        public static string Display(Object eventItem)
        {
            switch (eventItem)
            {
                case Course universityCourse:
                {
                    return universityCourse.GetSummaryInformation();
                }
                case Event e:
                {
                    return e.GetSummaryInformation();
                }
                case null:
                {
                    throw new ArgumentNullException($"Object passed in was null: " +
                                                    $"{nameof(eventItem)}");
                }
                default:
                {
                    return eventItem.ToString();
                }
            }
        }
    }
}