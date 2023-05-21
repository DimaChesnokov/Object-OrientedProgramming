using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassInterfacesAndEvents;

namespace ConsoleTestsIntefaces
{
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle(); // Создание экземпляра класса Circle.
            circle.Radius = 5;
            Console.WriteLine("Circle area: " + circle.CalculateArea()); // Вывод площади круга, вычисленной с помощью метода CalculateArea() класса Circle.
            Console.WriteLine("Circle perimeter: " + circle.CalculatePerimeter()); //Вывод периметра круга, вычисленного с помощью метода CalculatePerimeter() класса Circle.

            Rectangle rectangle = new Rectangle(); //Создание экземпляра класса Rectangle.
            rectangle.Width = 4; 
            rectangle.Height = 6;
            Console.WriteLine("Rectangle area: " + rectangle.CalculateArea()); // Вывод площади прямоугольника, вычисленной с помощью метода CalculateArea() класса Rectangle.  
            Console.WriteLine("Rectangle perimeter: " + rectangle.CalculatePerimeter()); //Вывод периметра прямоугольника, вычисленного с помощью метода CalculatePerimeter() класса Rectangle.
        }
    }
}
