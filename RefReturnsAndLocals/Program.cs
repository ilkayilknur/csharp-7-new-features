using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefReturnsAndLocals
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 9;
            Max(ref x, ref y) = 12;
            //x should be 12
            Console.WriteLine($"X={x}, Y={y}");
        }

        public static ref int Max(ref int first, ref int second)
        {
            if (first > second)
            {
                return ref first;
            }
            else
            {
                return ref second;
            }
        }
    }
}
