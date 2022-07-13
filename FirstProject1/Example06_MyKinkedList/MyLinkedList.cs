using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06_MyKinkedList
{
    internal class MyLinkedList<T>
    {
        // inner class  : 클래스 내에 클래스 타입 정의
        public class Node<K>
        {
            public K value;
            public Node<K> prev;
            public Node<K> next;
        }
        Node<T> first, last, tmp1, tmp2;

        public int Count
        {
            get
            {
                int tmpCount = 0;
                tmp1 = first;
                while (tmp1 != null)
                {
                    tmp1 = tmp1.next;
                    tmpCount++;
                }
                return tmpCount;
            }
        }

        public void AddFirst(T value)
        {
            tmp1 = new Node<T>();
            tmp1.value = value;
            if (first != null)
            {
                tmp1.next = first;
                first.prev = tmp1;
            }
            if (last == null)
                last = tmp1;
            first = tmp1;
        }

        public void AddLast(T value)
        {
            tmp1 = new Node<T>(vlaue);
            if (last != null)
            {
                tmp1.prev = last;
                last.next = tmp1;
            }
            if (first == null)
                first = tmp1;
            last = tmp1;
        }

        public void AddBefore(Node<T> node, T value)
        {
            tmp1 = new Node<T>();
            tmp1.value = value;

            node.prev = tmp1;
            node.next = tmp1;

            if (node == first)
                first = tmp1;

        }
        public void AddBrfore(T target, T value)
        {
            tmp1 = first;
            while (tmp1 != null)
            {
                if (Comparer<T>.Default.Compare(tmp1.value, target) == 0) ;




            }

        }

    }
