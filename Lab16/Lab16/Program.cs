/*Lab13
 * C# не поддерживает множественное наследование классов, 
 * но разрешено наследовать/реализовывать любое количество интерфейсов.
 * Lab15
 * расширенного наследования нет в c#, можно наследовать только интерфейсы.
 * Lab16
 * 1.Напишите программу, работающую со всеми четырьмя стандартными объектами iostream.
 * 2.	Напишите программу, предлагающую пользователю ввести  с клавиатуры его фамилию, 
 * имя и отчество как единое целое, а затем выводящую их на экран.
 * 3.	Напишите программу, выполняющую различные вычисления и  выводящую  значений с 
 * применение методов форматирования, манипуляторов и флагов объекта cout.*/

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
        }
    }
}
