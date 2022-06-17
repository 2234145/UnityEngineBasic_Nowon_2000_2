using System;

namespace Statement_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition1 = false;
            bool condition2 = false;
            bool condition3 = true;
            if (condition1)
            {
                // 조건이 참일 때 실행할 내용
                Console.WriteLine("이것은 참이야");
            }
            else if (condition2)
            {
                Console.WriteLine("조건2는 참이야");
            }
            else if (condition3)
            {
                Console.WriteLine("조건1, 2가 거짓이고, 조건 3은 참이야");
            }
            else
            {
                // 조건이 거짓일 때 실행할 내용
                Console.WriteLine("이것은 거짓이야");
            }
        }
    }
}
