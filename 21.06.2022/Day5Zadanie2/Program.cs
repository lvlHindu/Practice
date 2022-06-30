using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day5Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("NowiyFayl.txt");
            Console.WriteLine("Введите данные для записи: ");
            sw.WriteLine(Console.ReadLine());
            sw.Close();
            Console.Clear();
            StreamReader sr = new StreamReader("NowiyFayl.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            Console.ReadKey();
        }
    }
}
