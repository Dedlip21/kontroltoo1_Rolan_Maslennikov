using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontroltoo1_Rolan_Maslennikov
{
    public class Alamprogram
    {
        public static void Min()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 10);
            int num2 = rnd.Next(1, 10);
            int minNum;

            Console.WriteLine("Number 1 - " + num1);
            Console.WriteLine("Number 2 - " + num2);

            if (num1 < num2)
            {
                minNum = num1;
            }
            else
            {
                minNum = num2;
            }
            Console.WriteLine("Minimum number is - " + minNum);
            Console.ReadKey();
        }
    }
}
