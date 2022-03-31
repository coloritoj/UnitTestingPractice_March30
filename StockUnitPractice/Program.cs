using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockUnitPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] charArray = new char[9];

            string test = "Hello123";

            for (int i = 0; i < 8; i++)
            {
                charArray[i] = test[i];
            }

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            Console.ReadLine();
        }
    }
}
