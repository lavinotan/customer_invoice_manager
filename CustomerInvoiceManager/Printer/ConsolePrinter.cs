using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign07.Printer
{
    class ConsolePrinter
    {
        public static void PrintError(string errorMessage)
        {
            Console.WriteLine($"{errorMessage}");
        }
    }
}
