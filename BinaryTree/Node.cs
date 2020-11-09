using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        public Boolean ValueIsSet;
        private IComparable _value;
        public Node lower { get; set; }
        public Node higher { get; set; }
        public IComparable Value
        {
            get => _value; set
            {
                ValueIsSet = true;
                lower = new Node();
                higher = new Node();
                _value = value;
            }
        }

        public Node()
        {
            this.ValueIsSet = false;
        }

        public Node(IComparable startingValue)
        {
            Value = startingValue;
        }

    }
}
