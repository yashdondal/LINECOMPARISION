using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    public class LengthEqual
    {
        public static void Length()
        {
            double x1;
            double y1;
            double x2;
            double y2;
            double a, b;
            double X1, Y1, X2, Y2;



            Console.WriteLine("line1 \n ");
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

            Console.WriteLine(" lenght of the line 1 is = {0}", a);


            //line2
            Console.WriteLine("\n ------------------------------\n ");
            Console.WriteLine(" line 2");
            Console.WriteLine("enter the cordinates of starting point ie x1 and y1  ");
            Console.WriteLine("enter the cordinates of starting point ie x2and y2  ");

            X1 = Convert.ToDouble(Console.ReadLine());
            Y1 = Convert.ToDouble(Console.ReadLine());
            X2 = Convert.ToDouble(Console.ReadLine());
            Y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" the starting point of x axis x1 : {0}", X1);
            Console.WriteLine(" the end point of x axis x2 : {0}  ", X2);
            Console.WriteLine(" the starting point of y axis y1 : {0}", Y1);
            Console.WriteLine(" the end point of y axis y2  : {0}", Y2);








            b = Math.Sqrt(Math.Pow((Y2 - Y1), 2) + Math.Pow((X2 - X1), 2));
            Console.WriteLine(" lenght of the line 2 is = {0}", b);

            if (a == b)
            {

                Console.WriteLine(" length of both line is same");
            }
            else
            {
                Console.WriteLine("length of both line not equal");
            }
        }


    }

}

