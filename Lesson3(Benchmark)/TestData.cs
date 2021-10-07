using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson3;

namespace Lesson3_Benchmark_
{
     public class TestData
    {
      public PointClass[] FloatClassData;

     public   PointStruct[] FloatStructData;

     public   PointStructDouble[] DoubleStructData;

   


      public TestData()
        {
            FloatClassData = CreateFloatClassData();
            FloatStructData = CreateFloatStructData();
            DoubleStructData = CreateDoubleStructData();
       
        }


       private   PointClass[] CreateFloatClassData()
        {
            PointClass[] cArr = new PointClass[1000];

            for (int i = 0; i < cArr.Length; i++)
            {
                cArr[i] = new PointClass(i, i * i);
            }
            return cArr;
        }

        private PointStruct[] CreateFloatStructData()
        {
            PointStruct[] sArr = new PointStruct[1000];

            for (int i = 0;i<sArr.Length ; i++)
            {
                sArr[i] = new PointStruct(i, i * i);
            }
            return sArr;
        }
        private PointStructDouble[] CreateDoubleStructData()
        {
            PointStructDouble[] dsArr = new PointStructDouble[1000];

            for (int i = 0; i < dsArr.Length; i++)
            {
                dsArr[i] = new PointStructDouble(i, i * i);
            }
            return dsArr;
        }

    }
}
