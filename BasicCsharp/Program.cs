using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic.Print();
            Basic.PrintArray(4, 5, 5, 6, 7, 8, 9);
            Basic.PrintMax(4, 5, 5, 6, 7, 8, 9);
            Basic.PrintOdd();
            Basic.PrintSum();
            Basic.OddArray();
            Basic.GTY(10, 10, 12, 13, 14, 2, 4, 5, 6, 7, 8);
            Console.ReadLine();
        }
    }
}
