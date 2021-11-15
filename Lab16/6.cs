/*6.Напишите программу в которой ФИО вводятся из текстового файла и затем выводятся на экран.
 *7.Измените программы п.1 и п.2 на циклические.
 *8.Возьмите небольшой класс из предыдущих упражнений. Обязательно включите в его состав дружественные 
 *операции извлечения и вставки в поток. Напишите программу, создающую 2 объекта этого класса 
 *(в стеке и в свободной памяти). Значения членов-данных этих объектов  введите с клавиатуры оператором извлечения. 
 *Распечатайте содержимое этих объектов оператором вставки.*/

using System;
using System.IO;

namespace ReadingText
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            FileInfo F = new FileInfo(s);
            if (F.Exists)
            {
                StreamReader sr = new StreamReader(s);
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            else Console.WriteLine("Такого файла нет");


            Console.ReadLine();
        }
    }
}
