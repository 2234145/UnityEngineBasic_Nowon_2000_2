using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInherritance
{
    internal class Dog : Creature, IFourLeggedWalker
    {
        public void FourLeggedWalker()
        {
            throw new NotImplementedException();
        }
    }
}
