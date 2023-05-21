using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassInheritancee;

namespace ClassInheritancee
{
    public  class Vehicle
    {
        public string Brand { get; set; } // Свойство для хранения марки автомобиля
        public string Model { get; set; } // Свойство для хранения модели автомобиля
        public int Year { get; set; } // Свойство для хранения года выпуска автомобиля


        /// <summary>
        /// Метод для запуска двигателя автомобиля
        /// </summary>
        public void StartEngine()
        {
            Console.WriteLine("Двигатель запущен"); // Вывод сообщения о запуске двигателя
        }

        /// <summary>
        ///  Метод для остановки двигателя автомобиля
        /// </summary>
        public void StopEngine()
        {
            Console.WriteLine("Двигатель остановлен");
        }
    }

    /// <summary>
    /// // Класс Car наследуется от класса Vehicle
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// // Метод для движения автомобиля
        /// </summary>
        public void Drive()
        {
            Console.WriteLine("Автомобиль движется");
        }
    }
}
