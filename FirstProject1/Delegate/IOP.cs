using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class IOP
    {
        public delegate void OPDel(int a, int b);

        public OPDel Del { get; set; }
        public event OPDel DelEvent;
    }


    public class Op : IOP
    {
        public Op Del { get => throw new NotImplementedException(); set }
}
