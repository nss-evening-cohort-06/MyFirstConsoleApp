using System;

namespace MyFirstConsoleApp.Stuff
{
    class ConsoleGrabasdf
    {
        protected int _numberOfTimesIReadSomething;

        public int NumberOfTimesIReadSomething
        {
            get => _numberOfTimesIReadSomething;
        }

        public string StringToAppend { get; set; }

        public string GrabGently()
        {
            _numberOfTimesIReadSomething++;
            Console.WriteLine($"I've read {_numberOfTimesIReadSomething} lines.");
            return Console.ReadLine();
        }
    }
}