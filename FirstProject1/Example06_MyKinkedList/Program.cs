using System;
using System.Collections.Generic;
namespace Example06_MyKinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            myLinkedList.AddFirst(1);
            myLinkedList.AddFirst(2);
            myLinkedList.AddBefore(1, 3);

        }
    }
}
