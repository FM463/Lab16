/*19.Введите ФИО, возраст, вес одной строкой в символьный массив и  затем в программе получите 
 * отдельные переменные и выведите их на экран. Используйте функции ввода-вывода языка С.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    struct Record
    {
        string name, last_name, middle_name;
        int age, weight;
    };
    public void Main(string[] args)
    {
        const int N = 2;
        Record r[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter name, last_name, middle_name, age, weight through a space: ");
            string[] s = Console.ReadLine().Split(' ');
            Console.WriteLine($"name, last_name, middle_name: {s[0]} {s[1]} {s[2]}");
            Console.WriteLine($"age: {s[3]}");
            Console.WriteLine($"weight: {s[4]}");
        }
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"name, last_name, middle_name:{ r[i].last_name} { r[i].name} { r[i].middle_name} $\nAge: { r[i].age} \nWeight:\t { r[i].weight}";
        }
    }
}