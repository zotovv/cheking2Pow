using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheking2Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Console.WriteLine("Проверим, является ли число степенью 2.");
            Console.WriteLine("Введите число: ");

            int userNumber = Convert.ToInt32(Console.ReadLine());
            result = userNumber & (userNumber - 1);

            if (result == 0)
                {
                    Console.WriteLine("Это число является степенью 2 .");
                }
            else
                {
                    Console.WriteLine("Это число не является степенью 2 .");
                }
           
            Console.ReadKey();
            

        }
    }
}
