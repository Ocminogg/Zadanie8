using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8._6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>(new int[] {1,2,3,4,5,10});
            while (true)
            {
                Console.WriteLine("Введите ваше число для добавления");
                int num = Convert.ToInt32(Console.ReadLine());
                if (set.Contains(num)==false)
                {
                    set.Add(num);
                    Console.WriteLine("Мы добавили ваше число");
                }
                else
                {
                    Console.WriteLine("Такое число уже есть");
                    continue;
                }
            }
        }
    }
}
