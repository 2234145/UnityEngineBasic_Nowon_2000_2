using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class OPs
    {
        public enum OP
        {
            SUM,
            SUB,
            MUL,
            DIV,
            MOD,
        }

        public static int DoOP()
        {

        }

        static bool RefreshOP(OP op, int a, int b)
        {
            switch (op)
            {
                case OP.SUM:
                    result = Sum(a, b);
                case OP.SUB:
                    result = Sub(a, b);
                    break;
                case OP.MUL:
                    result = Mul(a, b);
                    break;
                case OP.DIV:
                    result = Div(a, b);
                    break;
                case OP.MOD:
                    result = Mod(a, b);
                    break;
            }
        }
        static int Sum(int a, int b)
        {

        }

        static int Sub(int a, int b) => a - b;

        static int Mul(int a, int b) => a * b;

        static int Div(int a, int b) => a / b;

        static int Mod(int a, int b) => a % b;
    }
}
