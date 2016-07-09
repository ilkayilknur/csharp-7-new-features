using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0b110;
            int y = 0b1000100;

            Console.WriteLine($"X={x}, Y={y}");

            Permissions permission = Permissions.Read | Permissions.Write;
            Console.WriteLine(permission);
        }
    }

    //Using binary literals with flag enums.
    [Flags]
    enum Permissions
    {
        Create = 0b1,
        Read = 0b10,
        Write = 0b100,
        Delete = 0b1000,
    }
}
