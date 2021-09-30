using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplicityCheckingStuff A = new SimplicityCheckingStuff();
            A.IsSimple(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
