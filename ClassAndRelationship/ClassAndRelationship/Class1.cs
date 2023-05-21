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
        public string Name;  // Публичное поле для хранения имени
        public int Age; // Публичное поле для хранения возраста

        /// <summary>
        /// // Конструктор, принимающий имя и возраст
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        public Person(string name, int age)
        {
            Name = name; // Инициализация поля имени значением, переданным в конструкторе
            Age = age; // Инициализация поля возраста значением, переданным в конструкторе
        }

        /// <summary>
        /// // Метод для вывода приветствия с именем
        /// </summary>
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
        public abstract double CalculateArea();  // Абстрактный метод, который должен быть реализован в производных классах

        // Обычный метод,  выводящий сообщение о том, что это фигура
        public void DisplayShape()
        {
            Console.WriteLine("Это фигура.");
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }  // Свойство для хранения радиуса круга

        /// <summary>
        /// // Конструктор, принимающий радиус круга
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius)
        {
            Radius = radius;  // Инициализация свойства радиуса значением, переданным в конструкторе
        }

        public override double CalculateArea() // Переопределение абстрактного метода CalculateArea() из базового класса
        {
            return Math.PI * Radius * Radius; // Вычисление площади круга (π * r^2)
        }
    }

    /// <summary>
    /// Статический класс
    /// </summary>
    public static class MathUtils
    {
        /// <summary>
        /// статический метод Add, который принимает два целочисленных параметра a и b и возвращает их сумму.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        ///  Это статический метод Multiply, который принимает два числа с плавающей запятой a и b и возвращает их произведение.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
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
        private List<Product> products; // Приватное поле для хранения списка товаров


        /// <summary>
        ///  Конструктор класса ShoppingCart
        /// </summary>
        public ShoppingCart()
        {
            products = new List<Product>(); // Создание нового списка товаров
        }

        /// <summary>
        /// Метод для добавления товара в корзину
        /// </summary>
        /// <param name="product">Продукт</param>
        public void AddProduct(Product product) 
        {
            products.Add(product); // Добавление товара в список
        }

        /// <summary>
        /// Метод для отображения списка товаров
        /// </summary>
        public void DisplayProducts()
        {
            foreach (Product product in products) // Перебор всех товаров в списке
            {
                Console.WriteLine(product.Name); // Вывод наименования товара
            }
        }

        /// <summary>
        /// Вложенный класс Product
        /// </summary>
        public class Product
        {
            public string Name { get; set; } // Свойство для хранения наименования товара
            public decimal Price { get; set; } // Свойство для хранения цены товара
        }
    }





}
