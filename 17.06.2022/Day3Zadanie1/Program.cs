using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day3Zadanie1
{
    class Program
    {
        struct MyTrain
        {
            public string RoadTo;
            public int NumberTrain;
            public DateTime date;
            public MyTrain(string a, int b, DateTime d)
            {
                this.RoadTo = a;
                this.NumberTrain = b;
                this.date = d;
            }            
            public void Write()
            {                
                Console.WriteLine($"Пункт назначения: {RoadTo} Номер поезда {NumberTrain} Время отправления {date}");
            }
        }
               
        static void Main(string[] args)
        {
            ArrayList nL = new ArrayList();

            MyTrain[] trains = new MyTrain[2];
            string d;
            int n;
            DateTime t;
            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("Введите пункт назначения: ");
                d = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Введите номер поезда: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Введите дату оправления: ");
                t = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine();
                trains[i] = new MyTrain(d, n, t);
            }

            Console.WriteLine("Введите номер поезда для поиска: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].NumberTrain == number)
                {
                    Console.WriteLine(trains[i].RoadTo + " " + trains[i].NumberTrain + " " + trains[i].date + " ");
                }
                else
                {
                    Console.WriteLine("Поезд не найден");
                }
            }
        }
    }
}
