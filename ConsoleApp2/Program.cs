using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    class prog
    {
        public static void Main()
        {
            CalCulator sq = new CalCulator();
            Console.WriteLine(sq.Add(3, 5));
            Console.WriteLine(sq.Multiply(3, 5));
            Console.WriteLine(sq.Subtract(5, 3));
            Console.WriteLine(sq.Division(5, 3));
            Console.WriteLine(sq.Modulus(5, 3));
            Console.ReadKey();
        }
    }
}