using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInherritance
{
    internal abstract class Creature
    {
        public string DNA;
        public int age;
        public float mass;
        public string name;

        public abstract void Breath()
        {
            
        }
    }
}
