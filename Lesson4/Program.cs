
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] testdata =new string[185000];

			for (int i = 0; i < testdata.Length; i++)
			{
                testdata[i] = Convert.ToString(Guid.NewGuid());
            }
              
            HashSet<string> hset = new HashSet<string>();

            for (int i = 0; i < 185000; i++)
            {
                hset.Add(testdata[i]);
            }

            string[] arr = new string[185000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = testdata[i];
            }


            List<string> list = new List<string>();

            for (int i = 0; i < 185000; i++)
            {
                list.Add(testdata[i]);
            }

            LinkedList<string> list2 = new LinkedList<string>();

            for (int i = 0; i < 185000; i++)
            {
                list2.AddLast(testdata[i]);
            }


            string searchdata = Convert.ToString(Guid.NewGuid());


            for (int i = 0; i < 55; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine();
                Stopwatch N = new Stopwatch();

                N.Start();

                list.Contains(searchdata);

                TimeSpan timeN = N.Elapsed;

                Console.WriteLine(timeN + " l");





                Stopwatch S = new Stopwatch();

                S.Start();

                hset.Contains(searchdata);

                TimeSpan timeS = S.Elapsed;

                Console.WriteLine(timeS + " hs");






                Stopwatch H = new Stopwatch();

                H.Start();

                list2.Find(searchdata);

                TimeSpan timeH = N.Elapsed;

                Console.WriteLine(timeH + " ll");





                Stopwatch J = new Stopwatch();

                J.Start();

                Array.Find<string>(arr, i => i == searchdata);

                TimeSpan timeJ = J.Elapsed;

                Console.WriteLine(timeJ + " arr");

                Console.WriteLine();
                Console.WriteLine();

            }

            Console.ReadKey();
        }       
    }

  
}
