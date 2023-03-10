using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_04_listas_ejercicio_01
{
    internal class MyList
    {
        // Attributes
        private MyNode firstNode;
        private MyNode lastNode;
        private int count;

        // Constructor
        public MyList() { }

        // Properties
        public MyNode FirstNode { get { return firstNode; } private set { firstNode = value; } }
        public MyNode LastNode { get { return lastNode; } private set {lastNode = value; } }
        public int Count { get { return count; } private set { count = value; } }

        // Methods
        /// <summary>
        /// Evaluates if a list is empty or not
        /// </summary>
        /// <returns>true if list is empty or false if not</returns>
        private bool IsEmpty()
        {
            return FirstNode == null;
        }

        /// <summary>
        /// Adds a node to the end of the list
        /// </summary>
        /// <param name="name">Property Name of the new node</param>
        /// <param name="surname">Property Surname of the new node</param>
        /// <param name="address">Property Address of the new node</param>
        /// <param name="tel">Property Tel of the new node</param>
        public void AddNodeEnd(MyNode newNode)
        {
            //MyNode newNode = new MyNode(name, surname, address, tel);
            if (IsEmpty())
            {
                FirstNode = LastNode = newNode;
            } else
            {
                LastNode.Next = newNode;
                LastNode = newNode;
            }
            Count++;
        }

        /// <summary>
        /// Adds a node after the selected one
        /// </summary>
        /// <param name="index">index of the node after which the new node will be added</param>
        /// <param name="newNode">Node to be added</param>
        public void AddNodeAfter(int index, MyNode newNode)
        {
            MyNode selectedNode = GetNode(index);
            if(selectedNode == LastNode)
            {
                AddNodeEnd(newNode);
            } else
            {
            newNode.Next = selectedNode.Next;
            selectedNode.Next = newNode;
            Count++;
            }
        }
        
        /// <summary>
        /// Deletes the selected node
        /// </summary>
        /// <param name="index">Index of the node to be removed</param>
        public void RemoveSelectedNode(int index)
        {
            MyNode prevNode = GetNode(index-1);
            MyNode selectedNode = GetNode(index);
            if(selectedNode == FirstNode)
            {
                FirstNode = FirstNode.Next;
            } else if(selectedNode == LastNode)
            {
                prevNode.Next = null;
            } else
            {
                prevNode.Next = selectedNode.Next;
            }
            Count--;
        }
        
        /// <summary>
        /// Updates the selected node
        /// </summary>
        /// <param name="index">Index of the node to be removed</param>
        /// <param name="updatedNode">Updated node in MyNode type</param>
        public void UpdateNode(int index, MyNode updatedNode)
        {
            MyNode previousNode = GetNode(index - 1);
            MyNode actualNode = GetNode(index);

            if(actualNode == FirstNode)
            {
                updatedNode.Next = FirstNode.Next;
                FirstNode = updatedNode;
            } else
            {
            previousNode.Next = updatedNode;
            updatedNode.Next = actualNode.Next;
            }

        }
        
        /// <summary>
        /// Gets the node according to the index provided
        /// </summary>
        /// <param name="index">Index of the node</param>
        /// <returns>The node whose index was provided</returns>
        public MyNode GetNode(int index)
        {
            MyNode actualNode = FirstNode;
            if(index == 0)
            {
                return actualNode;
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    actualNode = actualNode.Next;
                }
                return actualNode;
            }
        }
    }
}
