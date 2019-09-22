using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int menuOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("0. Wyjscie");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                if (menuOption == 0)
                    break;
            }
        }
    }
}
