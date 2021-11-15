/*10.Напишите программу, считывающую и распечатывающую двоичный файл, созданный в п.5 . 
 * Переменную для чтения объекта определить в стеке (свободной памяти).*/

using System;
using System.IO;
namespace readwriteapp
{
    class Fio
    {
        [STAThread]
        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Sample.txt");
                string path = @"path\to\my\file";
                byte[] data = File.ReadAllBytes(path);
                string dataString = String.Concat(data.Select(b => b.ToString("x2")));
                textBox.Text = dataString;
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}