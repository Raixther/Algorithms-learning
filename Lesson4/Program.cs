
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
 
            HashSet<string> hset = new HashSet<string>();

            for (int i = 0; i < 70000; i++)
            {
                hset.Add(Convert.ToString(Guid.NewGuid()));
            }

            string[] arr = new string[70000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToString(Guid.NewGuid());
            }

            List<string> list = new List<string>();

            for (int i = 0; i < 70000; i++)
            {
                list.Add(Convert.ToString(Guid.NewGuid()));
            }

            LinkedList<string> list2 = new LinkedList<string>();

            for (int i = 0; i < 70000; i++)
            {
                list2.AddLast(Convert.ToString(Guid.NewGuid()));
            }








          
                Stopwatch N = new Stopwatch();

                N.Start();

                list.Contains("stjsjytktkghkdktk");

                TimeSpan timeN = N.Elapsed;

                Console.WriteLine(timeN+" l");





                Stopwatch S = new Stopwatch();

                S.Start();

                hset.Contains("stjsjytktkghkdktk");

                TimeSpan timeS = S.Elapsed;

                Console.WriteLine(timeS+" hs");






                Stopwatch H = new Stopwatch();

                H.Start();

                list2.Find("stjsjytktkghkdktk");

                TimeSpan timeH = N.Elapsed;

                Console.WriteLine(timeH+" ll");





                Stopwatch J = new Stopwatch();

                J.Start();

                Array.Find<string>(arr, i => i == "stjsjytktkghkdktk");

                TimeSpan timeJ = J.Elapsed;

                Console.WriteLine(timeJ+" arr");

                Console.WriteLine();

            
        }
    }

  
}
