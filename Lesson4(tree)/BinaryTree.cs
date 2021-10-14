using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_tree_
{
	public class BinaryTree
	{
		 TreeNode root { get; set; }

		public BinaryTree()
		{
			root = null;

		}
		public void AddItem(int value)
		{
			TreeNode temp = root;

			TreeNode Node = new TreeNode();

			Node.Value = value;

			if (temp == null)
			{
				root = Node;
				return;
			}
			else
			{
				while (true)
				{
					if (Node.Value <= temp.Value)
					{
						if (temp.LeftChild == null)
						{
							temp.LeftChild = Node;
							return;
						}
						else
						{
							temp = temp.LeftChild;
						}
					}
					if (Node.Value > temp.Value)
					{
						if (temp.RightChild == null)
						{
							temp.RightChild = Node;
							return;
						}
						else
						{
							temp = temp.RightChild;
						}
					}
				}
			}

		}
	
		public TreeNode GetNodeByValue(int value)
		{
			TreeNode temp = root;
			while (true)
			{

				if (temp.Value == value)
				{
					return temp;
				}
				else if (temp.Value < value)
				{
					temp = temp.RightChild;
				}
				else if (temp.Value > value)
				{
					temp = temp.LeftChild;
				}

			}
		
			
		}

		public TreeNode GetRoot()
		{
			
			return root;
		}

		public void PrintTree()
		{
			if (root == null)
			{
				Console.WriteLine("дерево пусто");
			}
			else
			PreOrderTravers(root);
		}

		static void PreOrderTravers(TreeNode root, string s = "")
		{
			if (root != null)
			{
				Console.Write(root.Value); // К
				if (root.LeftChild != null || root.RightChild != null)
				{
					Console.Write("(");
					if (root.LeftChild != null) PreOrderTravers(root.LeftChild);
					else Console.Write("NIL");
					Console.Write(",");
					if (root.RightChild != null) PreOrderTravers(root.RightChild);
					else Console.Write("NIL");
					Console.Write(")");
				}
			}
		}


		public void RemoveItem(int value)
		{
			TreeNode DelNode =  GetNodeByValue(value);

			if (DelNode == root&&(root.LeftChild==null&& root.RightChild==null))
			{
				root = null;
			}

			if (DelNode.LeftChild==null&&DelNode.RightChild==null)
			{
				DelNode = null;
			}
			else if (DelNode.LeftChild != null  && DelNode.RightChild == null)
			{
				DelNode.Value = DelNode.LeftChild.Value;

				DelNode.LeftChild = DelNode.LeftChild.LeftChild;
				
			}
			else if (DelNode.RightChild != null && DelNode.LeftChild == null)
			{
				DelNode.Value = DelNode.RightChild.Value;
				DelNode.RightChild = DelNode.RightChild.RightChild;
				
			}
			else if (DelNode.LeftChild != null && DelNode.RightChild != null)
			{
				TreeNode temp = DelNode.RightChild;

				TreeNode temp2 = DelNode.RightChild;

				while (temp.LeftChild!=null)
				{
					temp = temp.LeftChild;

					if (temp2.LeftChild.LeftChild!=null)
					{
						temp2 = temp2.LeftChild;
					}
				}
				DelNode.Value = temp.Value;

				temp2.LeftChild = null;

				
			}
		}




	}
}
