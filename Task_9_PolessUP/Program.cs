using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


            Console.ReadLine();
        }
    }
}
