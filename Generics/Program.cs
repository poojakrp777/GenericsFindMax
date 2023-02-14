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
            FindMaximum<int> findIntMax = new FindMaximum<int>();
            FindMaximum<float> findMaximumFloat = new FindMaximum<float>();
            FindMaximum<string> findstring = new FindMaximum<string>();
            Console.WriteLine("\nMaximum Integer value is : " + findIntMax.findMaxValue(599, 149, 853));
            Console.WriteLine("\nMaximum Floating value is : " + findMaximumFloat.findMaxValue(9.3f, 6.5f, 5.8f));
            Console.WriteLine("\nMaximum String value is: " + findstring.findMaxValue("Pooja","Abhi","Harshi"));
            Console.ReadLine();
        }
    }
}
