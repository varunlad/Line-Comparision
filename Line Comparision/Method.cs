using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    class Program
    { 
        public static float CompareLine()
        {
            Console.WriteLine("Enter first point of first line :");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second point  of first line :");
            float y1 = float.Parse(Console.ReadLine()); ;
            Console.WriteLine("Enter Third point  of first line :");
            float x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fourth point  of first line :");
            float y2 = float.Parse(Console.ReadLine());
            float v = x2 - x1;
            float w = y2 - y1;
            float x = v * v + w * w;
            Console.WriteLine("The length of a first line is :");
            Console.WriteLine(System.Math.Sqrt(x));

            Console.WriteLine("Enter first point of second line :");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second point of second line :");
            float b1 = float.Parse(Console.ReadLine()); ;
            Console.WriteLine("Enter Third point of second line :");
            float a2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fourth pointof second line :");
            float b2 = float.Parse(Console.ReadLine());
            float p = a2 - a1;
            float q = b2 - b1;
            float r = p * p + q * q;
            Console.WriteLine("The length of a second line is :");
            Console.WriteLine(System.Math.Sqrt(r));
            if (x == r)
            {
                Console.WriteLine("Length of Both the lines are equal");
            }
            else if (x > r)
            {
                Console.WriteLine("Length of Line 1 is Greater than Line 2");
            }
            else
            {
                Console.WriteLine("Length of Line 1 is Smaller than Line 2");
            }
            return 0;
        }
        static void Main(string[] args)
        {
            CompareLine();
            Console.ReadLine();
        }
    }
}
