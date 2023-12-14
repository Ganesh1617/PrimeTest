using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        void Display()
        {
            int cnt = 0, a;
            Console.WriteLine("Enter Number");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                if (a % 2 == 0)
                {
                    cnt++; break;
                }
            }
                if (cnt == 0)
                {
                    Console.WriteLine("Prime Number");
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Display();
            Console.ReadLine();
        }
    }
}