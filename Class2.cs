using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Class2
    {
       private static bool FinalResult;
       static void Main (string[] args)
        {
                int a=1;
                int b=1;
                FinalResult = a == b;
            Console.WriteLine("Result:"+ FinalResult);
            Console.ReadKey();
        }
    }
}