using System;
using System.Collections.Generic;

// Generic : 일반화
// 다양한 자료형에 대해서 유동적으로 갖다쓸 수 있도록 만드는 형태
// 1 + 1 + 1 + 1 + 1
// 2 + 2 + 2 + 2 + 2
// 3 + 3 + 3 + 3 + 3
// 4 + 4 + 4 + 4 + 4

// n + n + n + n + n

namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 박싱: 자료형을 객체타입으로 변환하는 과정
            // 언박싱: 객체타입을 원래 자료형으로 변환하는 과정
            // System.Collections를 더이상 사용하지 않는 이유는
            //
            System.Collections.ArrayList arrList = new System.Collections.ArrayList();
            arrList.Add(3);
            arrList.Add("철수");
            arrList.Add('A');

            // List
            List<int> list_int = new List<int>();
            List< float> list_float = new List<float>();
            List<List<int>> list_list_int = new List<List<int>>();

            // 추가
            list_int.Add(0);
            list_float.Add(1.0f);
            list_list_int.Add(list_int);
            list_list_int.Add(new List<int>());

            // 삭제
            list_int.Remove(0);
            list_list_int.RemoveAt(1);

            // 검색
            // list_int.Find(x => x == 0);
            list_int.Contains(0);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(list_int[i]);
            }


           // LinkedList
           LinkedList<int> linkedList = new LinkedList<int>();

           // 추가
           linkedList.AddLast(0);
           linkedList.AddFirst(1);
           linkedList.AddBefore(linkedList.Find(0), 3);
           Console.WriteLine(linkedList.First);
           
            // 삭제
            linkedList.RemoveLast();

            // Hashtable ( 박싱/ 언박싱 때문에 쓰지않음)
            //--------------------------------------------
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add("철수", 90);



           // Dictionary
           Dictionary<string, char> grades = new Dictionary<string, char>();


           // 추가
           grades.Add("철수", 'A');
           grades.Add("영희", 'B');

           // 삭제
           grades.Remove("철수");

           
           if (grades.TryAdd("영희", 'C'))
           {
                Console.WriteLine("영희 점수 C 추가");
           }
           else
           {
                Console.WriteLine($"영희 점수 이미 있음 : {grades["영희"]}");
           }
           foreach (var sub in grades)
           {
                Console.WriteLine(sub);
                Console.WriteLine(grades[sub]);
           }

           foreach (var sub in grades.Values)
           {
                Console.WriteLine(grades[sub]);
           }

            // Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue(); // queue 제일 앞에있는 아이템 반환 및 제거
            Console.WriteLine(queue.Dequeue());
            queue.Peek(); // 제일 앞에있는 아이템 반환
            queue.TryPeek(out int peek);

           // Stack
           Stack<int> stack = new Stack<int>();
           stack.Push(peek);
           
        }
    }
}
