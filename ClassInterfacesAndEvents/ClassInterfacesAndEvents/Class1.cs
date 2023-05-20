using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfacesAndEvents
{
    //События
    public class Button
    {
        public event EventHandler Click; // Определение события "Click" типа EventHandler

        public void OnClick()
        {
            // Invoke вызывает делегат, который содержит ссылки на все зарегистрированные
            // обработчики событий для события Click текущего объекта.
            Click?.Invoke(this, EventArgs.Empty); // Вызов события "Click"
        }
    }

    //Интерфейс
    /// <summary>
    /// Класс который определяет два метода.
    /// Классы, реализующие этот интерфейс, должны предоставить реализацию для всех его членов.
    /// </summary>
    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    //Классы реализующие эти методы с наследованием
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

}

