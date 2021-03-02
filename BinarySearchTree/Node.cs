using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        //member variables
        public int Data; // info hold on to 
        public Node RightNode;
        public Node LeftNode;

        // ctor
        public Node(int data)
        {
            Data = data;
        }
        // member methods
    }
}
