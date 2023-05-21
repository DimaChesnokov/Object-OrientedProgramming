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
        public virtual void Draw()
        {
            Console.WriteLine("Рисую общую фигуру");
        }
    }

    // Производный класс Круг
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Рисую круг");
        }
    }

    // Производный класс Прямоугольник
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Рисую прямоугольник");
        }
    }

    // Производный класс Треугольник
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Рисую треугольник");
        }
    }




    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Неизвестный звук");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Гав-гав!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Мяу-мяу!");
        }
    }


    //Полиморфизм с перегрузкой
    public class Z
    {
        public static void D(int k)
        {
            Console.WriteLine("Integer");
        }

        public static void D(double u)
        {
            Console.WriteLine("Double");
        }
    }












}
