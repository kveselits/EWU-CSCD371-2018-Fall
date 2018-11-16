using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate int AddMethod(int first, int second);

        static void Main(string[] args)
        {
            var manager = new NotaTimeManager();
            manager.TimeEventCreated = WhenTimeEventCreated;
            manager.RaiseEvent(); 
        }

        private static void WhenTimeEventCreated()
        {
            
        }

        private void InstanceMain()
        {
            AddMethod @delegate = DoAdd;

            Action<string> bar = DoStuff;

            Func<int, int, int> foo = DoAdd;
        }

        private void DoStuff(string @params)
        {

        }
        private int DoAdd(int a, int b)
        {
            return a + b;
        }
        public class NotaTimeManager
        {
            public event Action TimeEventCreated;
             /*public Action TimeEventCreated { get; set; }
              This is bad because anyone can invoke
                 */
            public void RaiseEvent()
            {
                TimeEventCreated?.Invoke();
            }
        }
    }
}
