using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CalCulator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }

            return num2 - num1;

        }
        public float Division(float num1, float num2)
        {
            return num1 / num2;
        }
        public float Modulus(float num1, float num2)
        {
            return num1 % num2;
        }
    }
}
