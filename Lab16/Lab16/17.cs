/*17.Запустите программу п.2 так, чтобы она выводила свои результаты не на экран, а в текстовый файл.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите свое ФИО");
            string[] fio = Console.ReadLine().Split(' ');
            Console.WriteLine(fio[0] + " " + fio[1][0] + " " + fio[2][0]); //фамилия и инициалы

            string data = System.IO.File.ReadAllText("input.txt");
            data = data.Replace('a', 'o');
            System.IO.File.WriteAllText("output.txt", data);

            FileStream fsRead = File.Open("input.txt");  //открытие
            StreamReader sr = new StreamReader(fsRead);     //присвоение
            FileStream fsWrite = File.Open("output.txt");   
            StreamWriter sw = new StreamWriter(fsWrite);

            string temp = sr.ReadLine(); // temp принимает строковое значение 'fio'

            while (!string.IsNullOrEmpty(temp))    //пока temp ненулевой
            {
                sw.Write(temp.Replace('a', 'o');    //в output.txt запишется 'Alex Jams'?
                temp = sr.ReadLine();          //забирается новая строка из input.txt
            }

            sr.Close();
            sw.Close();
            fsRead.Close();   //закрывается всё
            fsWrite.Close();
        }
    }
}
