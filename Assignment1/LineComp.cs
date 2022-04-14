using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class LineComp
    {
        public static int x1;
        public static int y1;
        public static int x2;
        public static int y2;
        public static int x3;
        public static int y3;
        public static int x4;
        public static int y4;
        public static void TwoLineInput()
        {
            Console.WriteLine();
            Console.WriteLine("Uc3 begin here................................................................");
            Console.WriteLine();

            Console.WriteLine("Enter the coordinates value for points ");
            Console.WriteLine("Enter coordinate x for point1 of Line1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point1 of Line1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate x for point2 of Line1");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point2 of Line1");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coordinate x for point1 of Line2");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point1 of Line2");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate x for point2 of Line2");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point2 of Line2");
            y4 = Convert.ToInt32(Console.ReadLine());

        }

        public static void LineLength()
        {
            double value1, value2;
            TwoLineInput();
            double z1 = ((x1 * x1 - x2 * x2) + (y1 * y1 - y2 * y2));
            double z2 = ((x3 * x3 - x4 * x4) + (y3 * y3 - y4 * y4));

            if (z1 < 0)
            {
                value1 = z1 * (-1);
            }
            else
            {
                value1 = z1;
            }
            double length1 = Math.Sqrt(value1);


            if (z2 < 0)
            {
                value2 = z2 * (-1);
            }
            else
            {
                value2 = z2;
            }
            double length2 = Math.Sqrt(value2);

            Console.WriteLine("Length of line1 is : {0} units ", length1);
            Console.WriteLine("Length of line2 is : {0} units ", length2);


            if (length1 < length2)
            {
                Console.WriteLine("line 1 of length {0} units is less than Line 2 of length {1} units ", length1, length2);
            }
            else if (length1 > length2)
            {
                Console.WriteLine("line 1 of length {0} units is greater than Line 2 of length {1} units ", length1, length2);
            }
            else
            {
                Console.WriteLine("line 1 of length {0} units is equal to Line 2 of length {1} units", length1, length2);
            }
        }

    }
}
