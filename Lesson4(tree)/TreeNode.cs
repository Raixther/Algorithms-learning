using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_tree_
{	
        public class TreeNode
        {
            public int Value { get; set; }
            public TreeNode LeftChild { get; set; }
            public TreeNode RightChild { get; set; }

            public override bool Equals(object obj)
            {
                var node = obj as TreeNode;

                if (node == null)
                    return false;

                return node.Value == Value;
            }
        }





    
}
