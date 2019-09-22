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
                Console.WriteLine("0. Wyjscie");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnozenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. Wystrzeliwanie w kosmos");
                Console.WriteLine("lubie placki");
                int menuOption = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 0)
                    break;
            }
        }
    }
}
