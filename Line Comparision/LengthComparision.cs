using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    class Program
    { 
        static void Main(string[] args)
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
           Console.WriteLine(System.Math.Sqrt(x)) ;

            Console.WriteLine("Enter first point of second line :");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second point of second line :");
            float b1 = float.Parse(Console.ReadLine()); ;
            Console.WriteLine("Enter Third point of second line :");
            float a2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fourth pointof second line :");
            float b2 = float.Parse(Console.ReadLine());
            float p = x2 - x1;
            float q = y2 - y1;
            float r = p * p + q * q;
            Console.WriteLine("The length of a second line is :");
            Console.WriteLine(System.Math.Sqrt(r));
            if(x==r)
            {
                Console.WriteLine("Both the lines are equal");
            }
            else
            {
                Console.WriteLine("Both the lines are not equal");
            }
            Console.ReadLine();
        }
    }
}
