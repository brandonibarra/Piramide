using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;
            do
            {
                Console.Write("Ingresa la altitud de la piramide ( 0 a 25) : ");
                val = int.Parse(Console.ReadLine());
            }
            while (val < 0 || val > 25);
            for (int i = 1; i <= val; i++)
            {
                for (int j = i; j <= val; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
