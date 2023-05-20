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
            Circle circle = new Circle();
            circle.Radius = 5;
            Console.WriteLine("Circle area: " + circle.CalculateArea());
            Console.WriteLine("Circle perimeter: " + circle.CalculatePerimeter());

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 4;
            rectangle.Height = 6;
            Console.WriteLine("Rectangle area: " + rectangle.CalculateArea());
            Console.WriteLine("Rectangle perimeter: " + rectangle.CalculatePerimeter());
        }
    }
}
