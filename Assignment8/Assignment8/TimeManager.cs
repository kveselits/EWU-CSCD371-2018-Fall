using System.Globalization;

namespace Assignment8
{
    public class TimeManager
    {
        public bool Running { get; private set; }
        public IDateTime Current { get; set; }

        public class DateTime : IDateTime
        
        {
            public string Now()
            {
                return System.DateTime.Now.ToString(CultureInfo.CurrentCulture);
            }
        }
    }
}