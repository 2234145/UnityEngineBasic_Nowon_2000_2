using System;
// enum (snumerated type) 열거형
// enum 의 기본요소는 모두 int 형
// enum 의 기본형은 한번에 하나의 요소만 표현가능하다
enum PlayerState
{
    Idle,    // ... 00000000
    Attack,  // ... 00000001
    Jump,    // ... 00000010
    Walk,    // ... 00000011
    Run,     // ... 00000100
    Dash,    // ... 00000101
    Home,    // ... 00000110
}

// Flags Attribute
// Tostring()에서 명시되지 않은 enum 요소에 대해서 다른 요소들로 구성되는 문자열로 변환해줄 수 있는 속성
// Attribute 
[Flags]
enum PlayerStateFlags
{
    Idle = 0 << 0,   // ... 00000000
    Attack = 1 << 0, // ... 00000001
    Jump = 1 << 1,   // ... 00000010
    Walk = 1 << 2,   // ... 00000100
    Run = 1 << 3,    // ... 00001000
    Dash = 1 << 4,   // ... 00010000
    Home = 1 << 5,   // ... 00100000
}

namespace Enum_SwitchCase
{
    static bool doAttack;
    static bool doJump;
    static bool doWalk;
    static bool doRun;
    static bool doDash;
    static bool doHome;

    static PlayerState initState = PlayerState.Attack;
    static PlayerState flags = PlayerState.Attack | PlayerState.Jump;

    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(flags);

            Warrior warrior = new Warrior();
            warrior.name = "먼지전사";

            if (doAttck)
                warrior.Attack();
            else if (doJump)
                warrior.Jump();
            else if



            switch (initState)
            {
                   case PlayerState.Idle:
                        break;
                   case PlayerState.Attack:
                        warrior.Attack();
                        break;
                   case PlayerState.Jump:
                        warrior.Jump();
                        break;
                   case PlayerState.Walk:
                        warrior.Walk();
                        break;
                   case PlayerState.Run:
                        warrior.Run();
                        break;
                   case PlayerState.Dash:
                        warrior.Dash();
                        break;
                   case PlayerState.Home:
                        break;
                   default:
                        break;
            }

            // 동작명령
            Console.WriteLine("전사에게 명령을 내려주세요");
            string order = Console.ReadLine();

            if (Enum.TryParse(order, out PlayerState orderState));
            {
                switch (orderState);
            }
            else
            {
                Console.WriteLine("동작이 올바르지 않습니다.");
            }
        }
    }


    class Warrior
    {
        public string name;

        public void Attack()
        {
            Console.WriteLine($"{name}"가 공격함)
        }


    }

}
