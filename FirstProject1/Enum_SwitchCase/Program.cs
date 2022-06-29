using System;
// enum (snumerated type) 열거형
// enum 의 기본요소는 모두 int 형
enum PlayerState
{

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

    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.name = "먼지전사";

            if (doAttck)
                warrior.Attack();
            else if (doJump)
                warrior.Jump();
            else if



            switch (initSate)
            {
                    default:
            }
        }
    }


    class Warrior
    {
        public string name;

        public void Attack()
        {

        }


    }

}
