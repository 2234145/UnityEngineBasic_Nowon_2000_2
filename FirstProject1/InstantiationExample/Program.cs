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
            Human human1 = new Human(100f, '남');
            Human human2 = new Human(200f, '여');

            human1.age = 100;
            human2.age = 50;

            human1.SayMyAge();
            human2.SayMyAge(); 
            Human.SayClassName();
        }
    }

    class Human
    {
        // 접근 제한자
        // private: 외부클래스/ 객체에서 접근할 수 없도록 제한
        // public: 외부 클래스/ 객체에서 접근할 수 있도록 제한해제
        // internal : 동일 프로젝트에서 public 처럼 동작함
        // protected:  자식만 접근가능하도록 제한
        //
        // class의 멤버들은 접근제한자를 명시하지 않으면 기본적으로 private
        // 접근제한자를 명확하게 명시해야하는 이유는
        // 제3자가 봤을 때 접근하면 안되는 멤버에 접근하는 등의 사고로 인해
        // 코드를 잘못 작성할 가능성을 없애기 위함
        public int age;
        private float height;
        private char genderChar;

        public static void SayClassName()
        {
         
        }
        
        public void SayMyAge()
        {
          Console.WriteLine(age);
        }

        public Human(float height, char genderChar)
        {
            this.height = height; 
            this.genderChar = genderChar;
        }
    }
}