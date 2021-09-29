using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public static class SimplicityCheckingStuff
    {
       private  static int d = 0;

       private static int i = 2;
       static public void IsSimple(int n)
        {
       
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            if (d == 0)
            {
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не Простое");
            }
        }
      }
    }

