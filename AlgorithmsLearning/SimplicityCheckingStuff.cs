using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class SimplicityCheckingStuff
    {
       private int d = 0;

       private int i = 2;

        public void IsSimple(int n)
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

