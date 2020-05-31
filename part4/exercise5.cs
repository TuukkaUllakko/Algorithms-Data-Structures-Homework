using System;

namespace part4
{
    class BinarySearchTree //Created a new Nodes class for this (in the bottom), so I don't have to give anything as parameters
    {
        public Nodes root;
        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Add(int x)
        {
            Nodes node = new Nodes();
            node.value = x;

            if (this.root == null)
            {
                this.root = node;
            }
            else
            {
                Nodes current = this.root;
                Nodes parent;
                while (true)
                {
                    parent = current;
                    if (x < current.value)
                    {
                        current = current.leftSide;

                        if (current == null)
                        {
                            parent.leftSide = node;
                            break;
                        }
                    }
                    else
                    {
                        current = current.rightSide;

                        if (current == null)
                        {
                            parent.rightSide = node;
                            break;
                        }
                    }
                }
            }
        }
        public int Height()
        {
            Nodes current = this.root;
            return GetHeight(current);
        }
        public int GetHeight(Nodes node)
        {
            if (node == null)
            {
                return -1;
            }

            int left = GetHeight(node.leftSide);
            int right = GetHeight(node.rightSide);

            if (left > right)
            {
                return left + 1;
            }
            else
            {
                return right + 1;
            }
        }
    }
    class Nodes
    {
        public Nodes leftSide;
        public Nodes rightSide;
        public int value;
    }
}