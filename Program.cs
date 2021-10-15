using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace kontroltoo1_Rolan_Maslennikov
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // ülesanne 1
            Console.WriteLine("Say 1 to see maximum number\nSay 2 to see minimum number");
            
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Alamprogram.Max();
                    break;
                case 2:
                    Alamprogram.Min();
                    break;
            }
            Console.WriteLine(" ");


            Console.ReadLine();
        }
    }
}
