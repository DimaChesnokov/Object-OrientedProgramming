﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Двигатель запущен");
        }

        public void StopEngine()
        {
            Console.WriteLine("Двигатель остановлен");
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Автомобиль движется");
        }
    }
}
