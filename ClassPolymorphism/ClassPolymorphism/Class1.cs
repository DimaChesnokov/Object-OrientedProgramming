 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPolymorphism
{
    //Полиморфизм с помощью виртуальных методов (Базовый класс)

    // Базовый класс Фигура
    public class Shape
    {
        /// <summary>
        /// виртуальный метод Draw(), который имеет базовую реализацию для рисования общей фигуры.
        /// </summary>
        public virtual void Draw()
        {
            Console.WriteLine("Рисую общую фигуру");
        }
    }

    /// <summary>
    /// Это производный класс от Shape, представляющий круг. 
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// переопределен метод Draw(), который выводит сообщение "Рисую круг".
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("Рисую круг");
        }
    }

    /// <summary>
    /// Это производный класс от Shape, представляющий прямоугольник.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// переопределен метод Draw(), который выводит сообщение "Рисую прямоугольник".
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("Рисую прямоугольник");
        }
    }

    /// <summary>
    /// Это производный класс от Shape, представляющий треугольник. 
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// переопределен метод Draw(), который выводит сообщение "Рисую треугольник".
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("Рисую треугольник");
        }
    }




    /// <summary>
    /// Это базовый класс, представляющий животное.
    /// </summary>
    public class Animal
    {
        /// <summary>
        ///  виртуальный метод MakeSound(), который имеет базовую реализацию для вывода "Неизвестный звук".
        /// </summary>
        public virtual void MakeSound()
        {
            Console.WriteLine("Неизвестный звук");
        }
    }

    /// <summary>
    /// Это производный класс от Animal, представляющий собаку
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// переопределен метод MakeSound(), который выводит сообщение "Гав-гав!".
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Гав-гав!");
        }
    }

    /// <summary>
    ///  Это производный класс от Animal, представляющий кошку. 
    /// </summary>
    public class Cat : Animal
    {
        /// <summary>
        /// переопределен метод MakeSound(), который выводит сообщение "Мяу-мяу!".
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Мяу-мяу!");
        }
    }


    //Полиморфизм с перегрузкой
    /// <summary>
    ///  Это класс, в котором определены два статических метода  c одним и тем же именем D, но с различными параметрами.
    /// </summary>
    public class Z
    {
        /// <summary>
        ///  Это метод, принимающий целочисленный параметр k.
        /// </summary>
        /// <param name="k"></param>
        public static void D(int k)
        {
            Console.WriteLine("Integer");
        }

        /// <summary>
        ///  Это метод, принимающий параметр типа double u
        /// </summary>
        /// <param name="u"></param>
        public static void D(double u)
        {
            Console.WriteLine("Double");
        }
    }












}
