using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_2
{
    class Program
    {

        static void Main(string[] args)
        {
            // xxxxxxxxx x.x.

            decimal s = 0;
            Console.WriteLine("Введите последовательность из 11 символов");
            s = Convert.ToDecimal(Console.ReadLine());


            string result = String.Format("{0:######### (#)(#)}", s);

            Console.WriteLine(result);




        }
    }
}
