using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassInterfacesAndEvents;

namespace ConsoleTests
{
    class Program
    {
        static void Main()
        {
            Button button = new Button(); //Создание экземпляра класса Button.

            // Подписка на событие "Click" и определение обработчика события
            for (int i=0;i<=1;i++)
                button.Click += Button_Click; // В данном случае, цикл выполняется дважды, чтобы добавить два обработчика события.

            // Генерация события "Click"
            button.OnClick(); // Это вызывает все зарегистрированные обработчики событий "Click".
        }

        /// <summary>
        /// Метод Button_Click, который является обработчиком события "Click". В данном случае, метод просто выводит сообщение "Button clicked!" на консоль.
        /// </summary>
        /// <param name="sender">объект, который инициировал событие</param>
        /// <param name="e"> аргументы события</param>
        static void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked!");
        }
    }
}
