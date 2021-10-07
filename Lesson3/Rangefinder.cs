using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public static class Rangefinder
    {
        public static float FindRange1(PointClass A, PointClass B)
        {
            return MathF.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }

        public static float FindRange2(PointStruct A, PointStruct B)
        {
            return MathF.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }

        public static double FindRange3(PointStructDouble A, PointStructDouble B)
        {
            return Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }

        public static float FindRange4(PointStruct A, PointStruct B)
        {
            return ((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }

    }
}
