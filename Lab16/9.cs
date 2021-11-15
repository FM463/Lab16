/*9.Используйте  любой ранее разработанный класс. Напишите программу, создающую в цикле несколько объектов 
 * этого класса в стеке (свободной памяти). Запишите этот объекты в двоичный файл.
 12.Напишите программу, создающую в цикле несколько объектов этого класса в стеке (свободной памяти). 
Запишите этот объекты последовательно в двоичный файл, пользуясь методами класса.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем новый стек.
            var stack = new Stack<int>();

            // Добавляем новые элементы в стек.
            stack.Push(1);
            stack.Push(7);
            stack.Push(42);
            stack.Push(69);
            stack.Push(-17);
            Console.Write($"Стек содержит {stack.Count} элементов.");
        }
        protected static volatile int i = 0;
        private static void Main(string[] args)
        {
            ABCDE[] arr = new ABCDE[10];
            for (i = 0; i < 10; i++)
                arr[i] = new ABCDE(i);
        }
    }
    public sealed class ABCDE
    {
        private readonly object _number;

        public ABCDE(int number)
        {
            _number = number;
        }

        internal int Number
        {
            get { return (int)_number; }
        }
    }
}
