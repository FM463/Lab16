/*15.Напишите программу, которая выводит аргументы командной строки в обратном порядке и не выводит имя программы.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16     // код, в рамках которого выводятся в консоль переданные приложению аргументы
{
    class Argument
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Work with args directly:");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadKey();
        }
    }
}
