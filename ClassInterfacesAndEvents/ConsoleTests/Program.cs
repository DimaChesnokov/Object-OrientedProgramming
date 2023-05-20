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
            Button button = new Button();

            // Подписка на событие "Click" и определение обработчика события
            for(int i=0;i<=1;i++)
                button.Click += Button_Click;

            // Генерация события "Click"
            button.OnClick();
        }

        static void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked!");
        }
    }
}
