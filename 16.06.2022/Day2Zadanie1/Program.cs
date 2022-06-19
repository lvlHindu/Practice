using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Zadanie1
{
    class MyMatrix
    {
        private int[,] matrix = null;

        private int numberOfCols;
        private int numberOfRows;

        public int NumberOfCols
        {
            get { return numberOfCols; }
        }
        public int NumberOfRows
        {
            get { return numberOfRows; }
        }


        public MyMatrix(int numberOfCols, int numberOfRows)
        {
            if (numberOfCols < 0 || numberOfRows < 0)
            {
                Console.WriteLine("Значения не могут быть отрицательынми");
            }
            else
            {
                this.numberOfCols = numberOfCols;
                this.numberOfRows = numberOfRows;
                matrix = new int[numberOfCols, numberOfRows];
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ChangeMatrix(int x, int y)
        {
            List<int> drugayMatrica = new List<int>();
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    drugayMatrica.Add(matrix[i, j]);
                }
            }
            numberOfCols = x;
            numberOfRows = y;
            matrix = new int[numberOfCols, numberOfRows];
            int counter = 0;
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    if (counter < drugayMatrica.Count)
                    {
                        matrix[i, j] = drugayMatrica[counter];
                        counter++;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        public void SetElement()
        {
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int V;
            int Z;
            Console.WriteLine("Введите количество строк: ");
            V = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Введите количество столбцов: ");
            Z = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            MyMatrix matrix = new MyMatrix(V, Z);
            Console.WriteLine("Введите элементы матрицы: ");
            matrix.SetElement();
            matrix.ShowMatrix();
            matrix.ChangeMatrix(10, 12);
            matrix.ShowMatrix();
        }
    }
}
