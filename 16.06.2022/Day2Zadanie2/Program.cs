using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Zadanie2
{
    class Article
    {
        public string _name;
        public string _storeName;
        public decimal _price;

        public Article(string name, string shop, decimal price)
        {
            _name = name;
            _storeName = shop;
            _price = price;
        }        
        public override string ToString()
        {
            return $"название: {_name}, магазин: {_storeName}, цена: {_price}";
        }
        public static decimal operator +(Article obj1, Article obj2)
        {
            return obj1._price + obj2._price;
        }
    }
    class Store
    {
        private Article[] art;
        public int Length { get; private set; }
        public Store(int length)
        {
            Length = length;
            art = new Article[Length];
        }
        public Article this[int index]
        {
            get
            {
                if (IsValid(index))
                    return art[index];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (IsValid(index))
                    art[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }

        private bool IsValid(int index)
        {
            return (index >= 0) && (index < Length);
        }
        public Article FindProduct(string name)
        {
            foreach (Article item in art)
            {
                if (item._name == name)
                    return item;
            }
            return null;
        }        
    }
    class Program
    {        
        static void Main(string[] args)
        {
                Store Art = new Store(6);
                Art[0] = new Article("Штаны", "Adidas", 4300);
                Art[1] = new Article("Куртка", "Rebbok", 5340);
                Art[2] = new Article("Кофта", "Nike", 3040);
                Art[3] = new Article("Штаны", "Nike", 3599);
                Art[4] = new Article("Кроссовки", "Nike", 4499);
                Art[5] = new Article("Поясная сумка", "Nike", 2999);
            for (int i = 0; i < Art.Length; i++)
            {
                Console.WriteLine(Art[i]);
            }
            Console.WriteLine();
            Console.WriteLine("1 - поиск товара по индексу");
            Console.WriteLine("2 - поиск товара по названию");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {

                case 1:
                    while (true)
                    {
                        try
                        {
                            Console.Write("Введите индекс товара: ");

                            Article test1 = Art[Convert.ToInt32(Console.ReadLine())];
                            if (test1 != null)
                                Console.WriteLine(test1.ToString());
                        }
                        catch
                        {
                            Console.WriteLine("Товара с таким индексом нет");
                        }                        
                    }
                case 2:
                    Console.Write("Введите название товара: ");
                    Article test = Art.FindProduct(Console.ReadLine());                    
                    if (test != null)
                        Console.WriteLine(test.ToString());
                    break;
            }
        }
    }    
}
