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
            //Заполняем словарь PhoneBook
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
        }
    }
}
