using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Zadanie3
{
    static public class ArrayExtension
    {
        public static int[] Sort(this int[] array)
        {
            for (int p = 0; p < array.Length; p++)
            {
                for (int j = 0; j < array.Length - p - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }                
            }
            return array;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Введите длинну массива: ");
            x = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int[] array = new int[x];
            Console.WriteLine("Вводите числа массива: ");
            while (i != array.Length)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                i += 1;
            }
            foreach (int n in array)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            array.Sort();
            foreach (int n in array)
            {
                Console.Write(n + " ");
            }
            Console.ReadKey();
        }
    }
}
