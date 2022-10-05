using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    public class LengthOfLine
    {
        public static void Length()
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            double a;
            Console.WriteLine("enter the cordinates of starting point ie x1 and y1  ");
            Console.WriteLine("enter the cordinates of starting point ie x2and y2  ");

            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" the starting point of x axis x1 : {0}", x1);
            Console.WriteLine(" the end point of x axis x2 : {0}  ", x2);
            Console.WriteLine(" the starting point of y axis y1 : {0}", y1);
            Console.WriteLine(" the end point of y axis y2  : {0}", y2);



            a = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));

            Console.WriteLine(" lenght of the line is = {0}", a);
        }
    }
}

