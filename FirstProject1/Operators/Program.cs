using System;

namespace Operators
{
    internal class Program
    {
        static int a = 14;
        static int b = 6;
        static int c;
        static void Main(string[] args)
        {
            // 산술연산
            // 더하기, 빼기, 곱하기, 나누기, 나머지
            //==================================================

            // 더하기
            c = a + b;
            Console.WriteLine(c);

            // 빼기
            c = a - b;
            Console.WriteLine(c);

            // 곱하기
            c = a * b;
            Console.WriteLine(c);

            // 나누기: 정수간의 나눗셈은 정수 몫만 반환, 실수간의 나눗셈은 소숫점
            c = a / b;
            Console.WriteLine(c);

            // 나머지: 정수연산시의 ( 정수몫 * 오른쪽 피연산자) 를 왼쪽 피연산자에 뺀 값을 반환
            c = a % b;
            Console.WriteLine(c);

            // 증감 연산자
            // 증가 연산자
            //=================================

            //증가연산
            ++c; // 전위연산 : 해당라인에서 연산을 먼저 수행한 후에 명령실행
            c++; // 후위연산 : 해당라인에서 명령을 먼저 수행한 후에 연산실행
            c = 0;
            Console.WriteLine(++c);
            Console.WriteLine(c++);
            Console.WriteLine(c);

            // 감소연산

            --c; // 전위연산
            c--; // 후위연산

            // 관계연산
            // 같음, 다름, 크기비교 연산자
            // 관계연산자의 연산결과가 참이면 true, 거짓이면 false를 반환

            //같음비교
            Console.WriteLine(a == b);

            //다름비교
            Console.WriteLine(a != b);

            //큰지비교
            Console.WriteLine(a > b);

            //크거나 같은 비교
            Console.WriteLine(a >= b);

            // 작은지 비교
            Console.WriteLine(a < b);

            //작거나 같은 비교
            Console.WriteLine(a <= b);

            // 대입 연산자
            // 더해서 / 빼서 / 나누어서 / 곱해서 / 나머지를 대입하는 연산자
            //======================================================================
            c = 20;
            c += b; // c = c + b;
            c -= b;
            c /= b;
            c *= b;
            c %= b;

            // 논리연산자
            // or, and, xor, not
            //=====================================
            bool A = true;
            bool B = false;

            // or
            // a와b 둘 중 하나라도 참이면 참 반환 나머지 경우 거짓 반환
            Console.WriteLine(A | B);

            //and
            // a와b 둘 다 true면 true 반환, 나머지 경우 false 반환
            Console.WriteLine(A & B);

            // xor
           // a와b 둘 중 하나만 true면 true 반환, 나머지 경우 false 반환
           Console.WriteLine(A ^ B);
             
           // not
           // 피연산자가 true이면 false, false이면 true 반환
           Console.WriteLine(!A);
           
            //조건부 논리연산자
            // 조건부 or, 조건부 and
            //====================================

            // 조건부 or
            Console.WriteLine(A || B);

            //조건부 and
            Console.WriteLine(A && B);

            // 비트연산자
            // or, and, xor, not, shift-left, shift-right
            int HowManyBitYouWantToShift = 1;

            Console.WriteLine(a | b);
            Console.WriteLine(a & b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(~a);
            Console.WriteLine(a << HowManyBitYouWantToShift);
            Console.WriteLine(a >> HowManyBitYouWantToShift);
        }
    }
}
