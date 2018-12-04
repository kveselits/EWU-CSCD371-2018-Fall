using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment9
{
    public static class Enumerable
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> incomingCollection)
        {
            Random random = new Random();
            return incomingCollection.OrderBy(item => random.Next());
        }
    }
}