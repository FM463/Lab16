/*19.Введите ФИО, возраст, вес одной строкой в символьный массив и  затем в программе получите 
 * отдельные переменные и выведите их на экран. Используйте функции ввода-вывода языка С.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    public static void Main()
    {

        Console.Write("Введите кол-во людей: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите ФИО, возраст, вес через пробел: ");
        Record[] person = new Record[n];
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ');

            person[i].last_name = s[0];
            person[i].name = s[1];
            person[i].middle_name = s[2];
            person[i].age = Int32.Parse(s[3]);
            person[i].weight = Int32.Parse(s[4]);

        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"ФИО: {person[i].last_name} {person[i].name} {person[i].middle_name}");
            Console.WriteLine($"Возраст: {person[i].age}");
            Console.WriteLine($"Вес: {person[i].weight}");
        }

        Console.ReadLine();
    }
    struct Record
    {
        public string name, last_name, middle_name;
        public int age, weight;
    };
}