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
            Vehicle vehicle = new Vehicle();
            vehicle.Brand = "Toyota";
            vehicle.Model = "Corolla";
            vehicle.Year = 2019;
            vehicle.StartEngine();  // Выводит: Двигатель запущен

            Car car = new Car();
            car.Brand = "BMW";
            car.Model = "X5";
            car.Year = 2022;
            car.StartEngine();      // Унаследованный метод, выводит: Двигатель запущен
            car.Drive();            // Собственный метод класса, выводит: Автомобиль движется
            car.StopEngine();       // Унаследованный метод, выводит: Двигатель остановлен
        }
    }
}
