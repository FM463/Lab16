/*16.Напишите программу, которая принимает параметр – имя текстового файла и открывает его для чтения. 
 * Если файла нет – печатает сообщение и завершает работу. Прочитайте все символы из этого файла, 
 * но выводите на экран только русские буквы и знаки препинания.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class ConsoleMeeting
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
                    Console.WriteLine(new string(line.Where(c => "абвгдеёжзийклмнопрстуфхцчшщъыьэюя,.".Contains(Char.ToLower(c))).ToArray()));
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            else Console.WriteLine("Такого файла нет");
 
 
            Console.ReadLine();
        }
    }
}
