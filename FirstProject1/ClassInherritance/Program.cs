using System;
using System.Collections.Generic
namespace ClassInherritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();
            creature.Breath();


            Human human = new Human();
            human.name = "실험체1";
            human.Breath();
            human.Grow();
            human.Grow();

            Yellowman yellowman = new Yellowman();
            yellowman.name = "황인종1";
            yellowman.Grow();
            Blackman blackman = new Blackman();
            blackman.name = "흑인종1";
            blackman.Grow();
            Whiteman whiteman = new Whiteman();
            whiteman.name = "백인종3";
            whiteman.Grow();


            // 자식객체는 부모타입으로 참조가 가능하다 (공변성)
            List<Human> men = new List<Human>();
            Human man1 = new Yellowman();
            men.Add(new Yellowman());
            men.Add(new Blackman());
            men.Add(new Whiteman());
            for (int i = 0; i < 10; i++)
            {
                men[i].name = $"사람{i + 1}";
                men[i].Grow();
            }

            List<ITwoLeggedWlaker> twoLeggedWlakers = new List<ITwoLeggedWlaker>();
            twoLeggedWlakers.Add(new Yellowman());
            twoLeggedWlakers.Add(new Whiteman());
            twoLeggedWlakers.Add(new Blackman());
            for (int i = 0;i < men.Count;i++)
            {
                twoLeggedWlakers[i].TwoLedggedWalker();
            }
            

        }
    }
}
