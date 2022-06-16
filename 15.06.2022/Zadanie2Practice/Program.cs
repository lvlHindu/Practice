using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2Practice
{
    class Program
    {
        class Point
        {
            private int X;
            private int Y;
            private string Name;

            public Point(int a, int b, string c)
            {
                X = a;
                Y = b;
                Name = c;
            }
            public int x
            {
                get
                {
                    return X;
                }
            }
            public int y
            {
                get
                {
                    return Y;
                }
            }
            public string name
            {
                get
                {
                    return Name;
                }
            }
        }
        class Figure
        {
            private Point a;
            private Point b;
            private Point c;
            private Point d;
            private Point e;

            public Figure(Point A, Point B, Point C)
            {
                a = A;
                b = B;
                c = C;

            }
            public Figure(Point A, Point B, Point C, Point D)
            {
                a = A;
                b = B;
                c = C;
                d = D;
            }
            public Figure(Point A, Point B, Point C, Point D, Point E)
            {
                a = A;
                b = B;
                c = C;
                d = D;
                e = E;
            }
            private double LengthSide(Point a, Point b)
            {
                return Math.Sqrt(Math.Pow(a.x - b.x,2) + Math.Pow(b.y - b.y,2));
            }
            public void PerimeterCalculator()
            {
            	double res;
            	if (d == null)
            {
                res = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, a);
            }
            else
            {
                if (e == null)
                {
                    res = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, a);
                }
                else
                {
                    res = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, e) + LengthSide(e, a);
                }
            }
            Console.WriteLine("Периметр: " + res);
        }
        }
        static void Main(string[] args)
        {
            int low;
            Console.Write("Количество точек (не менее трех): ");
            low = Convert.ToInt32(Console.ReadLine());
            List<Point> points = new List<Point>();
            Console.WriteLine();
            int x;
            int y;
            string z;
            for (int i = 0; i < low; i++)
            {
                Console.Write("Введите координату X: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Введите координату Y: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Введите название точки: : ");
                z = (Console.ReadLine());
                Console.WriteLine();
                points.Add(new Point(x, y, z));
            }

            Figure figure = null;
            if(points.Count == 3)
            {
                figure = new Figure(points[0], points[1], points[2]);
            }
            else
            {
                if (points.Count == 4)
                {
                    figure = new Figure(points[0], points[1], points[2], points[4]);
                }
                else
                {
                    if (points.Count == 5)
                    {
                        figure = new Figure(points[0], points[1], points[2], points[4], points[5]);
                    }
                }
            }

            figure.PerimeterCalculator();
            Console.ReadKey();

        }
    }
}
