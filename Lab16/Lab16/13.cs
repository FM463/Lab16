/*13.Напишите программу для просмотра и редактирования объектов файла, созданного в п.2, в режиме прямого доступа.
 14.Введите ФИО, возраст, вес одной строкой в символьный массив и  затем в программе получите отдельные переменные 
и выведите их на экран. Используйте классы внутреннего ввода-вывода языка С++.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Введите свое ФИО");
            string[] fio = Console.ReadLine().Split(' ');
            Console.WriteLine(fio[0] + " " + fio[1][0] + " " + fio[2][0]); //фамилия и инициалы
            var text = File.ReadAllText(@"C:\words.txt");
            File.WriteAllText(@"C:\words.txt", text + "DERP");
            string[] str = File.ReadAllLines("1.txt");
            using (StreamWriter sw = new StreamWriter("1.txt"))
            {
                sw.AutoFlush = true;
                foreach (string s in str)
                {
                    if (!s.Contains("name"))
                    {
                        sw.WriteLine(s);
                    }
                }
            }
        }
    }
}