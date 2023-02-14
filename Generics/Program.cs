using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Using Generics");
            FindMax findMaximum = new FindMax();
            Console.WriteLine("\nMaximum Integer value is : " + findMaximum.findMaxValue<int>(599, 149, 853));
            Console.WriteLine("\nMaximum Floating value is : " + findMaximum.findMaxValue<float>(9.3f, 6.5f, 5.8f));
            Console.WriteLine("\nMaximum String value is: " + findMaximum.findMaxValue<string>("Pooja","Abhi","Harshi"));
            Console.ReadLine();
        }
    }
}
