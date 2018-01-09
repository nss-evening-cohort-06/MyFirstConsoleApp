using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp.Stuff
{
    class ConsoleGrab
    {
        protected int _numberOfTimesIReadSomething;
        
        public int NumberOfTimesIReadSomething { get { return _numberOfTimesIReadSomething; }}

        public string GrabGently()
        {
            _numberOfTimesIReadSomething++;
            Console.WriteLine($"I've read {_numberOfTimesIReadSomething} lines.");
            return Console.ReadLine();
        }
    }

    class SpecializedConsoleGrab : ConsoleGrab
    {
        public string Grab()
        {
            _numberOfTimesIReadSomething++;
            return Console.ReadLine();
        }
    }
}
