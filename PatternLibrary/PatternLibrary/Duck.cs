using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    //для примера был выбран паттерн проектирования "Стратегия"
    //для класса уток

    /// <summary>
    /// Абстрактный класс, прародитель различных классов уток
    /// </summary>
    public abstract class Duck
    {
        /// <summary>
        /// Объект класса определяющего поведение полёта
        /// </summary>
        public IFlyBehavior iFlyBehavior;
        /// <summary>
        /// Объект класса определяющего поведение издавать звуки
        /// </summary>
        public IQuackBehavior iQuackBehavior;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Duck() { }

        /// <summary>
        /// Полиморфный метод, отображающий объект
        /// Каждый конкретный класс уток должен задавать реализацию метода
        /// </summary>
        public abstract string Show();

        /// <summary>
        /// Объект iFlyBehavior должен иметь метод Fly(),
        /// позволяющий летать определённым образом.
        /// Делегирование операции соответствующему классу поведения
        /// </summary>
        public string PerformFly()
        {
            return iFlyBehavior.Fly();
        }

        /// <summary>
        /// Объект iQuackBehavior должен иметь метод Quack(),
        /// позволяющий издавать звуки определённым образом.
        /// Делегирование операции соответствующему классу поведения
        /// </summary>
        public string PerformQuack()
        {
            return iQuackBehavior.Quack();
        }

        //подразумевается что все утки умеют плавать, независимо от её вида
        const string MESSAGE_SWIM = "Я плаваю! Все утки умеют плавать!";
        /// <summary>
        /// Метод наследуемый потомками (плавание)
        /// </summary>
        public string Swim()
        {
            return MESSAGE_SWIM;
        }

        /// <summary>
        /// Метод позволяющий динамически изменять поведение полёта
        /// </summary>
        public void setIFlyBehavior(IFlyBehavior fb)
        {
            iFlyBehavior = fb;
        }

        /// <summary>
        /// Метод позволяющий динамически изменять поведение издаваемых звуков
        /// </summary>
        public void setIQuackBehavior(IQuackBehavior qb)
        {
            iQuackBehavior = qb;
        }
    }

    /// <summary>
    /// Интерфейсный класс - родитель классов поведения для свойства "летать"
    /// </summary>
    public interface IFlyBehavior
    {
        string Fly();
    }

    /// <summary>
    /// Интерфейсный класс - родитель классов поведения для свойства "издавать звуки"
    /// </summary>
    public interface IQuackBehavior
    {
        string Quack();
    }

    /// <summary>
    /// Класс поведения. Задаёт способ полёта.
    /// </summary>
    public class FlyWithWings : IFlyBehavior
    {
        const string MESSAGE_FLY = "Я летаю - машу крыльями и летаю!";

        /// <summary>
        /// Способ полёта - крыльями машу
        /// </summary>
        /// <returns> сообщение о результате операции</returns>
        public string Fly()
        {
            return MESSAGE_FLY;
        }
    }

    /// <summary>
    /// Класс поведения. Задаёт способ полёта.
    /// </summary>
    public class FlyNoWay : IFlyBehavior
    {
        const string MESSAGE_FLY = "Я не летаю - хочу, но не могу летать!";

        /// <summary>
        /// Способ полёта - нет способностей
        /// </summary>
        /// <returns> сообщение о результате операции</returns>
        public string Fly()
        {
            return MESSAGE_FLY;
        }
    }

    /// <summary>
    /// Класс поведения. Задаёт способ издавания звуков.
    /// </summary>
    public class DefaultQuack : IQuackBehavior
    {
        const string MESSAGE_QUACK = "Я крякаю - кря-кря";

        /// <summary>
        /// Способ полёта - крыльями машу
        /// </summary>
        /// <returns> сообщение о результате операции</returns>
        public string Quack()
        {
            return MESSAGE_QUACK;
        }
    }

    /// <summary>
    /// Класс поведения. Задаёт способ издавания звуков.
    /// </summary>
    public class MuteQuack : IQuackBehavior
    {
        const string MESSAGE_QUACK = "Я не могу издавать звуки!";

        /// <summary>
        /// Способ полёта - молчание
        /// </summary>
        /// <returns> сообщение о результате операции</returns>
        public string Quack()
        {
            return MESSAGE_QUACK;
        }
    }
}
