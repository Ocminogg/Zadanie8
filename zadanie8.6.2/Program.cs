using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 8.6.2
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            PhoneBook.Add("1", "Жуков");
            PhoneBook.Add("2", "Тигров");
            PhoneBook.Add("3", "Козырев");
            //Заполняем словарь PhoneBook
            Console.WriteLine("Введите новые номера и ФИО из вашей Телефонной книги");
            while (true)
            {
                string[] Num = Console.ReadLine().Split(' ');
                if (Num[0] != "")
                {
                    PhoneBook.Add(Num[0], Num[1]);
                }
                else
                    break;
            }
            //Ищем ФИО по тел
            Console.WriteLine("Введите номер тел и мы найдем ваш контакт");
            while (true)
            {
                string Phone = Console.ReadLine();
                string FIO;
                if (PhoneBook.TryGetValue(Phone,out FIO) == true)
                {
                    Console.WriteLine($"Найденный контакт: {FIO}");
                }
                else
                {
                    Console.WriteLine("Контакт не найден. Чтобы искать другой нажмите 1!");
                    string con = Console.ReadLine();
                    if (con == "1") continue;
                    else break;
                }
            }
        }
    }
}
