using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //member variables
        public Node RootNode;

        // ctor
        public BinarySearchTree()
        {
            
        }

        // member methods
        public void AddNode(Node nodeToAdd) // less or greater than root node
        {
            if (nodeToAdd.Data > RootNode.Data)
            {
                RootNode.RightNode = nodeToAdd;
            }
            else
            {
                RootNode.LeftNode = nodeToAdd;
            }

        }

        public bool SearchNode(int dataToFind) // to see if data exisit
        {
            return false;
        }
    }
}
