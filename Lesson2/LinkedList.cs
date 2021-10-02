using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class LinkedList : ILinkedList
    {
        public Node StartNode { get; set; }
        public Node EndNode { get; set; }


        public LinkedList()
        {
            StartNode = null;
            EndNode = null;
        }

        public void AddNode(int value)
        {
            Node node = new Node();
            node.Value = value;

            if (StartNode == null)
            {
                StartNode = node;
                EndNode = node;
            }
            else
            {
                node.PrevNode = EndNode;
                node.PrevNode.NextNode = node;
                EndNode = node;
            }
        }

        public void AddNodeAfter(Node node, int value)
        {

            if (node == EndNode)
            {
                AddNode(value);
            }
            else
            {
                Node N = new Node();

                N.Value = value;

                N.PrevNode = node;

                N.NextNode = node.NextNode;

                N.PrevNode.NextNode = N;

                N.NextNode.PrevNode = N;
            }
        }
        public Node FindNode(int searchValue)
        {

            Node temp = StartNode;

            while (temp != null)
            {
                if (temp.Value == searchValue)
                {
                    return StartNode;
                }
                else
                {
                    temp = temp.NextNode;
                }
            }
            return temp;
        }

        public int GetCount()
        {

            if (StartNode == null)
            {
                return 0;
            }
            else
            {
                int counter = 1;
                Node temp = StartNode;


                while (temp.NextNode != null)
                {
                    counter++;

                    temp = temp.NextNode;
                }
                return counter;
            }
        }
        public void RemoveNode(int index)
        {

            if (index > GetCount()|index<1)
            {
                Console.WriteLine("индекс больше количества элементов");
            }

            else if (index == 1)
            {
                RemoveNode(StartNode);
            }

            else
            {
                int counter = 1;

                Node temp = StartNode;

                while (counter != index)
                {
                    temp = temp.NextNode;

                    counter++;
                }
                RemoveNode(temp);
            }
            }
            public void RemoveNode(Node node)
            {

                if (StartNode == EndNode)
                {
                    StartNode = null;

                    EndNode = null;
                }

                else if (node == StartNode)
                {
                    node.NextNode.PrevNode = null;

                    StartNode = node.NextNode;

                    node.NextNode = null;

                }
                else if (node == EndNode)
                {
                    node.PrevNode.NextNode = null;

                    EndNode = node.PrevNode;

                    node.PrevNode = null;
                }
                else
                {
                    node.PrevNode.NextNode = null;
                    node.NextNode.PrevNode = null;
                    node.PrevNode = null;
                    node.NextNode = null;
                }
            }
        }
    }

