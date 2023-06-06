using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home3
{
    /*Создайте класс «Веб-сайт». Необходимо хранить в
    полях класса: название сайта, путь к сайту, описание
    сайта, ip адрес сайта. Реализуйте методы класса для ввода
    данных, вывода данных, реализуйте доступ к отдельным
    полям через методы класса.
    */
    class WebSyte
    {
        string _name;
        string _path;
        string _description;
        string _iP;
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string iP { get; set; }

        public void InputData()
        {
            Console.Write("Введите название сайта: ");
            _name = Console.ReadLine();

            Console.Write("Введите URL сайта: ");
            _path = Console.ReadLine();

            Console.Write("Введите описание сайта: ");
            _description = Console.ReadLine();

            Console.Write("Введите IP-адрес сайта: ");
            _iP = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine("Название сайта: " + _name);
            Console.WriteLine("URL сайта: " + _path);
            Console.WriteLine("Описание сайта: " + _description);
            Console.WriteLine("IP-адрес сайта: " + _iP);
        }

    }
    /*Создайте класс «Журнал». Необходимо хранить в
    полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail.
    Реализуйте методы класса для ввода данных, вывода
    данных, реализуйте доступ к отдельным полям через
    методы класса.*/
    class Journal
    {
        string _name;
        public string Name { get; set; }

        string _year;
        public string Year { get; set; }

        string _description;
        public string Description { get; set; }

        string _number;
        public string Number { get; set; }

        string _email;
        public string Email { get; set; }

        public void InputData()
        {
            Console.Write("Введите название журнала: ");
            _name = Console.ReadLine();

            Console.Write("Введите год основания: ");
            _year = Console.ReadLine();

            Console.Write("Введите описание журнала: ");
            _description = Console.ReadLine();

            Console.Write("Введите контактный номер: ");
            _number = Console.ReadLine();

            Console.Write("Введите e-mail: ");
            _email = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine("Название журнала: " + _name);
            Console.WriteLine("Год основания журнала: " + _year);
            Console.WriteLine("Описание журнала: " + _description);
            Console.WriteLine("Контактный номер: " + _number);
            Console.WriteLine("e-mail: " + _email);
        }

    }
    /*Создайте класс «Магазин». Необходимо хранить в
    полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail.
    Реализуйте методы класса для ввода данных, вывода
    данных, реализуйте доступ к отдельным полям через
    методы класса.*/
    class Shop
    {
        string _name;
        public string Name { get; set; }

        string _addres;
        public string Addres { get; set; }

        string _description;
        public string Description { get; set; }

        string _number;
        public string Number { get; set; }

        string _email;
        public string Email { get; set; }

        public void InputData()
        {
            Console.Write("Введите название магазина: ");
            _name = Console.ReadLine();

            Console.Write("Введите адрес: ");
            _addres = Console.ReadLine();

            Console.Write("Введите описание магазина: ");
            _description = Console.ReadLine();

            Console.Write("Введите контактный номер: ");
            _number = Console.ReadLine();

            Console.Write("Введите e-mail: ");
            _email = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine("Название магазина: " + _name);
            Console.WriteLine("Адрес магазина: " + _addres);
            Console.WriteLine("Описание магазина: " + _description);
            Console.WriteLine("Контактный номер: " + _number);
            Console.WriteLine("e-mail: " + _email);
        }
    }

    internal class Program
    {
        /*Напишите метод, который отображает квадрат из
          некоторого символа.
        Метод принимает в качестве параметра: длину стороны квадрата, символ.*/
        static void square(int Length,char c)
        {
            char[,] arr = new char[Length,Length];
            for (int i = 0; i < Length; i++)
            {
                for(int j = 0; j < Length; j++)
                {
                    arr[i, j] = c;
                }
            }
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(arr[i,j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static bool IsPalindrom(int word, bool ignoreCase = true)
        {

            string str = word.ToString();
            if (ignoreCase)
            {
                str = str.ToLower();
            }

            for (int first = 0, last = str.Length - 1; first < last; ++first, --last)
            {
                if (str[first] != str[last])
                {
                    return false;
                }
            }

            return true;
        }
        public static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            int[] resultArray = new int[originalArray.Length];
            int index = 0;
            bool found;
            for (int i = 0; i < originalArray.Length; i++)
            {
                found = false;
                for (int j = 0; j < filterArray.Length; j++)
                {
                    if (originalArray[i] == filterArray[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    resultArray[index] = originalArray[i];
                    index++;
                }
            }
            Array.Resize(ref resultArray, index);
            return resultArray;
        }
        static void Main(string[] args)
        {
            //square(5,'*');
            //int a = 4884;
            //Console.WriteLine(IsPalindrom(a));
            /*int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };
            int[] filteredArray = FilterArray(originalArray, filterArray);
            foreach (int num in filteredArray)
            {
                Console.Write(num + " "); // Output: 1 2 -1
            }*/
            /*WebSyte website = new WebSyte();
            website.InputData();
            Console.Clear();
            website.OutputData();*/
            /*Journal journal = new Journal();
            journal.InputData();
            Console.Clear();
            journal.OutputData();*/
            /*Shop shop = new Shop();
            shop.InputData();
            Console.Clear();
            shop.OutputData();*/
        }
    }
}
