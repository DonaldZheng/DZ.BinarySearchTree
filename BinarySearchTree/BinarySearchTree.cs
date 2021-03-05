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
            if (RootNode == null) // if null is empty
            {
                RootNode = nodeToAdd; // add the node
                
            }
            else
            {
                Node currentNode = RootNode;
                while (true)
                {
                    if (currentNode.LeftNode == null && currentNode.Data > nodeToAdd.Data)// if current node is bigger than ?
                    {
                        currentNode.RightNode = nodeToAdd; // add to the left node // reference nevin's example
                        break; 
                    }
                    else if (currentNode.RightNode == null && currentNode.Data < nodeToAdd.Data)
                    {
                        currentNode.LeftNode = nodeToAdd;
                        break;
                    }
                }
            }

        }

        public bool SearchNode(int dataToFind) // to see if data exisit
        {
            if (RootNode != null) // if node is not empty
            {
                if (dataToFind < )
            }
            return false;
        }
    }
}
