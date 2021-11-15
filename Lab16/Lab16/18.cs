/*18.Перепишите  программу п.2 с применением функций ввода-вывода языка С.*/

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
            printf("Введите свое ФИО");
            string[] fio = getchar().Split(' ');
            printf(fio[0] + " " + fio[1][0] + " " + fio[2][0]); //фамилия и инициалы
        }
    }
}
