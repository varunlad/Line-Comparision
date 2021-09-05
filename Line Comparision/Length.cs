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
            Console.WriteLine("Enter first point :");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second point :");
            float y1 = float.Parse(Console.ReadLine()); ;
            Console.WriteLine("Enter Third point :");
            float x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fourth point :");
           float y2 = float.Parse(Console.ReadLine());
           float v = x2 - x1;
           float w = y2 - y1;
            Console.WriteLine("The length of a line is :");
            Console.WriteLine(System.Math.Sqrt(v * v + w * w)) ;
            Console.ReadLine();
        }
    }
}
