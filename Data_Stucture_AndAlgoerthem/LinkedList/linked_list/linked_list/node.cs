using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linked_list
{
    internal class node
    {
        internal int data;
        internal node next;
        public node(int d)
        {
            data = d;
            next = null;
        }
        public node()
        {
           
            next = null;
        }
    }
}
