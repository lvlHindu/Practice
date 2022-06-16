using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Practice
{
    class Program
    {
        class Rectangle
        {
            private double side1;
            private double side2;                        
            
            public Rectangle(double x, double y)
            {
                side1 = x; side2 = y;
            }
            public double Area
            {
                get
                {
                    return AreaCalculator();
                }
            }
            public double Perimeter
            {
                get
                {
                    return PerimeterCalculator();
                }
            }
            private double AreaCalculator()
            {
                return side1 * side2;
            }
           private double PerimeterCalculator()
            {
                return 2 * side1 + 2 * side2;
            }
        }
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.Write("Введите длины сторон прямоугольника ");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            Rectangle rec = new Rectangle(x,y);
            Console.WriteLine("Area is: " + rec.Area);
            Console.WriteLine("Perimeter is: " + rec.Perimeter);
        }
    }
}
