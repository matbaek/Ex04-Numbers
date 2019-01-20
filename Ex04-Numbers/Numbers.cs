using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Numbers
{
    public class Numbers
    {
        public static int RectangleArea(int v1, int v2)
        {
            return v1 * v2;
        }

        public static int Sum(int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            return sum;
        }

        public static int Min(int[] ints)
        {
            int lowerstNumber = ints[0];
            for(int i = 0; i < ints.Length; i++)
            {
                if(lowerstNumber > ints[i])
                {
                    lowerstNumber = ints[i];
                }
            }

            return lowerstNumber;
        }

        public static int Max(int[] ints)
        {
            int highestNumber = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (highestNumber < ints[i])
                {
                    highestNumber = ints[i];
                }
            }

            return highestNumber;
        }

        public static bool Contains(int v, int[] ints)
        {
            bool contain = false;
            for(int i = 0; i < ints.Length; i++)
            {
                if(v == ints[i])
                {
                    contain = true;
                    return contain;
                }
            }

            return contain;
        }

        public static double Average(int[] ints)
        {
            double average = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                average += ints[i];
            }
            average = average / ints.Length;
            return average;
        }

        public static double LineLength(int xa, int ya, int xb, int yb)
        {
            int x = xb - xa;
            int y = yb - ya;
            return Math.Sqrt(x * x + y * y);
        }

        public static double PolylineLength(int[] xCoords, int[] yCoords)
        {
            double result = 0;
            for(int i = 0; i < xCoords.Length - 1; i++)
            {
                result += LineLength(xCoords[i], yCoords[i], xCoords[i+1], yCoords[i+1]);
                
            }
            return result;
        }
    }
}
