using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp_lab1
{
    class Program
    {
        static int GetValue(string input)
        {
            int x;
            bool check = int.TryParse(input, out x);
            while (!check)
            {
                Console.WriteLine("It is not an integer! Input Integer:");
                input = Console.ReadLine();
                check = int.TryParse(input, out x);
            }
            Console.WriteLine("Your inputted value is " + x);
            return x = Convert.ToInt32(input);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input Integer 'a':");
                string input;
                int a = GetValue(input = Console.ReadLine());
                Console.WriteLine("Input Integer 'b':");
                int b = GetValue(input = Console.ReadLine());
                int deviding = a / b;
                Console.WriteLine("The result of dividing {0} by {1} is {2}", deviding, a, b);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
            Console.ReadKey();
        }
    }
}
