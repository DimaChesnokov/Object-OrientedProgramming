using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndRelationship
{
    /// <summary>
    /// Обычный класс
    /// </summary>
    public class Person
    {
        // Поля класса
        public string Name;
        public int Age;

        // Конструктор класса
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Метод класса
        public void SayHello()
        {
            Console.WriteLine($"Привет, меня зовут {Name}!");
        }
    }


    /// <summary>
    /// Абстрактный класс
    /// </summary>
    public abstract class Shape
    {
        // Абстрактный метод
        public abstract double CalculateArea();

        // Обычный метод
        public void DisplayShape()
        {
            Console.WriteLine("Это фигура.");
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    /// <summary>
    /// Статический класс
    /// </summary>
    public static class MathUtils
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }

    /// <summary>
    /// Перечисление
    /// </summary>
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    /// <summary>
    /// Вложенные классы
    /// </summary>
    public class ShoppingCart
    {
        private List<Product> products;

        public ShoppingCart()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }





}
