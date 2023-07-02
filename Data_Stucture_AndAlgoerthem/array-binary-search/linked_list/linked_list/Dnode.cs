using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linked_list
{
    internal class Dnode
    {
        internal int data;
        internal Dnode prev;
        internal Dnode next;
        public Dnode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
}
