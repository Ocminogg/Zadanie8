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
            //zadanie 8.6.1 
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(rnd.Next(0, 100));
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}; ");
            }
            Console.ReadKey();
            Console.WriteLine();
            ///////////////
            for (int i = 0; i < list.Count; i++)
            {
                if ((list[i] > 25) && (list[i] < 50))
                {
                    list.Remove(list[i]);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}; ");
            }
            Console.ReadKey();
        }
    }
}
