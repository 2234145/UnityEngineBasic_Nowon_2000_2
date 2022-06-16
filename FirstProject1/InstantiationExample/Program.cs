using System;

// Human 클래스를 만들고
// ( 정수형나이, 실수형 키, 문자형 성별문자를 멤버 변수로 가지고
//   나이를 Console 창에 출력하는 함수를 멤버함수로 가진다)
// Human 객체 2개 생성
// human1의 나이 100, 키 200, 성별 남
// human2의 나이 50, 키 150 성별 여
// 프로그램을 실행하면 각 사람이 본인의 나이를 콘솔창에 출력 
namespace InstantiationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            Human human1 = new Human();
            Human human2 = new Human();

            human1.age = 100:
            human1.height = 200f;
            human1.genderChar = '남'
            human2.age = 50:
            human2.height = 150f;
            human2.genderChar = '여'

            Console.WriteLine(human1.height);
            Console.WriteLine(human.age);
            Console.WriteLine(human1.weight);

            
            
            Console.WriteLine(human2.weight)
        }
    }

    class Human
    {
        public int age:
        public float height:
        public char genderChar;
        
        public void SayMyAge()
        {

        }

    }
}