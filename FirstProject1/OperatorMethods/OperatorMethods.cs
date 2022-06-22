using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorMethods
{
    internal class OperatorMethods
    {
        public static int Sum( int a, int b)
        {
            return a + b;
        }

        static public float Sum(int a, int b)
        {
            return a + b;
        }

        static public int Sub(int a, int b)
        {
            return a - b;
        }

        static public int Div(int a, int b)
        {
            return a / b;   
        }

        static public int Mul(int a, int b)
        {
            return a * b;
        }

        static public int Mod(int a, int b)
        {
            return a % b;
        }

        static public int Increase(int a)
        {
            return a++;
        }

        static public int Decrease(int a)
        {
            a--;
        }

        static public bool IsSame(int a, int b)
        {
            return a == b;
        }
    }
}
