using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Studing.DevFound.CS.FinalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial calculation (n!). Enter n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int F = 1;
            for (int i = 1; i <= n; i++) F = F * i;
            Console.WriteLine($"{n}!={F}");
        }
    }
}
