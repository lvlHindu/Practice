using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Zadanie3
{
    static class ColorPrint
    {
        public static void Print(string stroka, int color)
        {
            string n = " ";

            switch (color)
            {
                case (int)Color.Red:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case (int)Color.Blue:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case (int)Color.Green:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case (int)Color.Yellow:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }
                default:
                    if (Convert.ToBoolean(n)) {                      
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Строка дефотлтного цвета");
                         }
                    break;
            }
            Console.WriteLine(stroka);
        }
    }
    enum Color
    {
        Red = 1,
        Blue = 2,
        Green = 3,
        Yellow = 4,
        Default 
    }
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.WriteLine("Укажите цвет: (1 - красный, 2 - синий,  3 - зелёный, 4 - жёлтый)");
            int color = Convert.ToInt32(Console.ReadLine());            
            ColorPrint.Print(stroka, color);
            Console.ReadKey();
        }
    }
}
