using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Lesson3;

namespace Lesson3_Benchmark_
{
   
    [MemoryDiagnoser]
    [RankColumn]
    [KeepBenchmarkFiles]
    
    public class Benchmark
    {
        TestData testdata;

        public Benchmark()
        {
            testdata = new TestData();
        }
      
        [Benchmark]
        public void FindRange1Test()
        {
            for (int i = 0, j = 999; i < 1000&&j>=0; i++, j--)
            {
              Rangefinder.FindRange1(testdata.FloatClassData[i], testdata.FloatClassData[j]);
            }      
        }


        [Benchmark]
        public void FindRange2Test()
        {
            for (int i = 0, j = 999; i < 1000 && j >= 0; i++, j--)

            {
                Rangefinder.FindRange2(testdata.FloatStructData[i], testdata.FloatStructData[j]);
            }
        }





        [Benchmark]
        public void FindRange3Test()
        {
            for (int i = 0, j = 999; i < 1000 && j >= 0; i++, j--)
            {
                Rangefinder.FindRange3(testdata.DoubleStructData[i], testdata.DoubleStructData[j]);
            }
        }



        [Benchmark]
        public void FindRange4Test()
        {
            for (int i = 0, j = 999; i < 1000 && j >= 0; i++, j--)
            {
                Rangefinder.FindRange4(testdata.FloatStructData[i], testdata.FloatStructData[j]);
            }
        }


    }
}
