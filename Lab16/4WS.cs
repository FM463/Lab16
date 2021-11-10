/* 4.	Используя один из ранее разработанных классов (Worker, Student … ), 
 * создайте в программе список объектов путем ввода данных с клавиатуры и рапечатайте его на экране в виде таблицы.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Worker
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[6];
            for (int i = 0; i < 6; i++)
            {
                workers[i] = new Worker();
            }
            workers[0].Surname = "Иванов";
            workers[0].Name = "Иван";
            workers[0].Patronymic = "Иванович";
            workers[0].Post = "Директор";
            workers[0].Year = 1985;
            workers[0].Pay = 5000000;
            workers[1].Surname = "Петров";
            workers[1].Name = "Петр";
            workers[1].Patronymic = "Петрович";
            workers[1].Post = "Нач. отдела";
            workers[1].Year = 1990;
            workers[1].Pay = 4000000;
            workers[2].Surname = "Семёнов";
            workers[2].Name = "Семён";
            workers[2].Patronymic = "Семёнович";
            workers[2].Post = "Бухгалтер";
            workers[2].Year = 1995;
            workers[2].Pay = 3000000;
            workers[3].Surname = "Павлов";
            workers[3].Name = "Павел";
            workers[3].Patronymic = "Павлович";
            workers[3].Post = "Экономист";
            workers[3].Year = 2000;
            workers[3].Pay = 2500000;
            workers[4].Surname = "Егоров";
            workers[4].Name = "Егор";
            workers[4].Patronymic = "Егорович";
            workers[4].Post = "Менеджер";
            workers[4].Year = 2005;
            workers[4].Pay = 2000000;
            workers[5].Surname = "Сергеев";
            workers[5].Name = "Сергей";
            workers[5].Patronymic = "Сергеевич";
            workers[5].Post = "Уборщик";
            workers[5].Year = 2010;
            workers[5].Pay = 1500000;
            workers[5]++; // Прибавляем работнику миллион к зарплате с помощью перегруженного оператора ++
            workers[4] *= 10; // Умножаем работнику зарплату в 10 раз с помощью перегруженного оператора *
            // Сравниваем зарплаты двух работников с помощью перегруженного оператора >=
            if (workers[4] >= workers[5])
            {
                Console.WriteLine("Зарплата " + workers[4].Surname + " " + workers[4].Name + " " + workers[4].Patronymic + " не меньше, чем у " + workers[5].Surname + " " + workers[5].Name + " " + workers[5].Patronymic);
            }
            else
            {
                Console.WriteLine("Зарплата " + workers[4].Surname + " " + workers[4].Name + " " + workers[4].Patronymic + " меньше, чем у " + workers[5].Surname + " " + workers[5].Name + " " + workers[5].Patronymic);
            }
            // Сравниваем зарплаты двух работников с помощью перегруженного оператора <=
            if (workers[1] <= workers[2])
            {
                Console.WriteLine("Зарплата " + workers[1].Surname + " " + workers[1].Name + " " + workers[1].Patronymic + " меньше, чем у " + workers[2].Surname + " " + workers[2].Name + " " + workers[2].Patronymic);
            }
            else
            {
                Console.WriteLine("Зарплата " + workers[1].Surname + " " + workers[1].Name + " " + workers[1].Patronymic + " не меньше, чем у " + workers[2].Surname + " " + workers[2].Name + " " + workers[2].Patronymic);
            }
            Console.WriteLine("Количество объектов: " + Worker.Count);
            do
            {
                Console.WriteLine("Введите число лет работы, для вывода информации о работнике:");
                int years = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 6; i++)
                {
                    if (2015 - workers[i].Year > years)
                    {
                        Console.WriteLine("-----------------------");
                        workers[i].Show();
                    }
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine("Продолжить работу программы? (да/нет)");
            }
            while (Console.ReadLine() != "n");
        }
    }
    class Worker
    {
        private string _surname;
        private string _name;
        private string _patronymic;
        private string _post;
        private int _year;
        private int _pay;
        private static int _count;
        public static int Count
        {
            get { return _count; }
        }
        public Worker()
        {
            _count++;
        }
        // Оператор ++ Прибавляет к зарплате работника 1 млн
        public static Worker operator ++(Worker obj)
        {
            obj.Pay += 1000000;
            return obj;
        }
        // Оператор * умножает зарплату работника на заданное число
        public static Worker operator *(Worker obj, int x)
        {
            obj.Pay = obj.Pay * x;
            return obj;
        }
        // Оператор >= сравнивает зарплаты двух работников
        public static bool operator >=(Worker obj1, Worker obj2)
        {
            return obj1.Pay >= obj2.Pay;
        }
        // Оператор <= сравнивает зарплаты двух работников
        public static bool operator <=(Worker obj1, Worker obj2)
        {
            return obj1.Pay <= obj2.Pay;
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }
        public string Post
        {
            get { return _post; }
            set { _post = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public int Pay
        {
            get { return _pay; }
            set { _pay = value; }
        }
        public void Show()
        {
            Console.WriteLine("Информация по работнику:");
            Console.WriteLine("Фамилия: {0}", Surname);
            Console.WriteLine("Имя: {0}", Name);
            Console.WriteLine("Отчество: {0}", Patronymic);
            Console.WriteLine("Должность: {0}", Post);
            Console.WriteLine("Год поступления на работу: {0}", Year);
            Console.WriteLine("Зарплата: {0}", Pay);
        }
    }
}
