using System;
using MyFirstConsoleApp.Stuff;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleGrab = new ConsoleGrab();
            var consoleGrab2 = new SpecializedConsoleGrab();
            
            Console.WriteLine("This is my first console app!");
            string inputString = consoleGrab.GrabGently();
            Console.WriteLine(inputString);

            Console.WriteLine(consoleGrab.NumberOfTimesIReadSomething);

            consoleGrab2.Grab();
        }
    }
}
