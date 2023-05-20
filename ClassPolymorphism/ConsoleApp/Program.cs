using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassPolymorphism;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            example1();
        }

        static void example1()
        {

            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle();
            shapes[1] = new Rectangle();
            shapes[2] = new Triangle();

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }


        static void example2()
        {
            Animal animal1 = new Dog();
            Animal animal2 = new Cat();

            animal1.MakeSound(); // Вывод: Гав-гав!
            animal2.MakeSound(); // Вывод: Мяу-мяу!
        }
    }
}
