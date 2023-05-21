using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassAndRelationship;


namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            example1();
            example2();
            example3();
            example4();
            example5();
        }

        public static void example1()
        {
            Person person = new Person("Алиса", 25);
            person.SayHello();  // Выводит: "Привет, меня зовут Алиса!"
        }

        public static void example2()
        {
            Circle circle = new Circle(5);
            circle.DisplayShape();          // Выводит: "Это фигура."
            double area = circle.CalculateArea();  // Вычисляет площадь круга
            Console.WriteLine(area);       // Выводит: 78.53981633974483
        }

        public static void example3()
        {
            int sum = MathUtils.Add(5, 3);  // Вызов статического метода Add
            Console.WriteLine(sum);        // Выводит: 8

            double product = MathUtils.Multiply(2.5, 4.0);  // Вызов статического метода Multiply
            Console.WriteLine(product);                    // Выводит: 10.0
        }

        public static void example4()
        {
            DaysOfWeek today = DaysOfWeek.Tuesday;
            Console.WriteLine(today);  // Выводит: Tuesday

            int dayNumber = (int)today;
            Console.WriteLine(dayNumber);  // Выводит: 1

            if (today == DaysOfWeek.Saturday || today == DaysOfWeek.Sunday)
            {
                Console.WriteLine("Сегодня выходной!");
            }
            else
            {
                Console.WriteLine("Сегодня рабочий день.");
            }
        }

        public static void example5()
        {
            ShoppingCart cart = new ShoppingCart();

            ShoppingCart.Product product1 = new ShoppingCart.Product
            {
                Name = "Книга",
                Price = 15.99m
            };
            cart.AddProduct(product1);

            ShoppingCart.Product product2 = new ShoppingCart.Product
            {
                Name = "Флешка",
                Price = 9.99m
            };
            cart.AddProduct(product2);

            cart.DisplayProducts();

        }
    }
}
