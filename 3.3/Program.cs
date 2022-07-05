using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    internal class Program
    {
       static void Main(string[] args)
        {
            
            int n;
            int i = 2;
            bool prostoe = true;

            Console.WriteLine("Введите число  ");
            n = int.Parse(Console.ReadLine());
           
            while (i <= n - 1)
            {
                i++;
                if (n % i == 0)
                {
                    prostoe = false;
                    break;
                }
            }
            if (prostoe)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            Console.ReadKey();
        }
           
            
  

      
    }
}
