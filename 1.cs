using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Сейчас :" + DateTime.Now);
            Console.WriteLine("Через 33 месяца :" + DateTime.Now.AddMonths(33));
        }
    }
}
