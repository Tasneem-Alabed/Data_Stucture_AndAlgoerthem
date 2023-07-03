using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linked_list
{
    internal class DLL
    {
        internal Dnode head;

        public void insert(int value)
        {
            Dnode newNode = new Dnode(value);
            newNode.next = head;
            newNode.prev = null;
            if (head != null)
            {
                head.prev = newNode;
            }
            head = newNode;
        }

    }
}
