using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassInheritancee;


namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(); // Создание экземпляра класса Vehicle
            vehicle.Brand = "Toyota"; // Установка значения свойства Brand
            vehicle.Model = "Corolla"; // Установка значения свойства Model
            vehicle.Year = 2019; // Установка значения свойства Year
            vehicle.StartEngine(); // Вызов метода StartEngine() для экземпляра vehicle, выводит: Двигатель запущен

            Car car = new Car(); // Создание экземпляра класса Car
            car.Brand = "BMW"; // Установка значения свойства Brand
            car.Model = "X5"; // Установка значения свойства Model
            car.Year = 2022; // Установка значения свойства Year
            car.StartEngine(); // Вызов унаследованного метода StartEngine() для экземпляра car, выводит: Двигатель запущен
            car.Drive(); // Вызов собственного метода Drive() для экземпляра car, выводит: Автомобиль движется
            car.StopEngine(); // Вызов унаследованного метода StopEngine() для экземпляра car, выводит: Двигатель остановлен
        }
    }
}
