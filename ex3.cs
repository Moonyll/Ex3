using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            int div;
            Console.WriteLine("a ?");
           int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("b ?");
            int b = int.Parse(Console.ReadLine());
            a = 33 + a;
            b = 1 + b; // ou b++;
            div = a / b;
            Console.WriteLine(div);













        }
    }
}
