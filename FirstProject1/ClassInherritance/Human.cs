using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInherritance
{
    internal class Human : Creature, ITwoLeggedWlaker, IFourLeggedWalker
    {
        public string Name;
        public float height;

        public override void Breath()
        {
            Console.WriteLine($"{name}이가 숨을 쉰다!");
        }

        public void FourLeggedWalker()
        {
            Console.WriteLine($"{name}이가 사족보행을 한다!");
        }

        //virtual: 자식 클래스가 재정의 할 수 있도록

        public virtual void Grow()
        {
            mass += 10.0f;
            height += 5.0f;
            Console.WriteLine($"{name} 이 자랐다! {mass}, {height}");
        }

        public void TwoLedggedWalker()
        {
            Console.WriteLine($"{name}이가 이족보행을 한다!");
        }
    }
}
