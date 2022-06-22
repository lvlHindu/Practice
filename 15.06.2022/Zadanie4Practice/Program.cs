﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4Practice
{
    internal class Program
    {


        public class Employee
        {
            public string name;
            public string surname;
            public string post;
            public int exp;

            public Employee(string n, string s)
            {
                name = n;
                surname = s;
            }
        }

        static void Worker(Employee emp)
        {
            Console.WriteLine("Выберите должность:\n1. Программист\n2. Тестировщик\n3. Инженер");

            switch (Console.ReadLine())
            {
                case "1":
                    emp.post = "Программист";
                    break;
                case "2":
                    emp.post = "Тестировщик";
                    break;
                case "3":
                    emp.post = "Инженер";
                    break;
            }

            Console.Write("Введите стаж: ");
            emp.exp = int.Parse(Console.ReadLine());

            double zp = 0;
            int a = 0;
            double b = 0;

            if (emp.post == "Программист")
                zp = 50000;
            else if (emp.post == "Тестировщик")
                zp = 40000;
            else if (emp.post == "Инженер")
                zp = 60000;


            for (int i = 0; i < emp.exp; i++)
            {
                a = i;
            }

            Console.WriteLine("\nИнформация о сотруднике:\nИмя - {0}, Фамилия - {1}, Должность - {2}, Оклад - {3}, Сбор - {4}", emp.name, emp.surname, emp.post, zp + (a * 1400), b = 7000);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();

            Employee em = new Employee(name, surname);

            Worker(em);
        }
    }
}
