using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Bubble sorting 

          
            Console.ReadLine();
        }

        public void bubbleSort()
        {
             var item = new int[] { 7, 5, 6, 4 };

            for (int j = 0; j < item.Length; j++)
            {
                int swap = 0;
                for (int i = 0; i < item.Length - 1; i++)
                {
                    int temp = 0;
                    if (item[i] > item[i + 1])
                    {
                        temp = item[i];
                        item[i] = item[i + 1];
                        item[i + 1] = temp;
                        swap++;
                    }

                }
                if (swap == 0) break;
            }
        }
        
        public async static Task<int> message()
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            Task<string> obj  =  client.GetStringAsync("http://msdn.microsoft.com");

            DoIndependentWork();

            await obj;
            //Console.WriteLine("this is a delete method");
            return obj.Result.Length;
        }

        private static void DoIndependentWork()
        {
            //throw new NotImplementedException();
        }
    }
    
    public class student
    {
        public string Name{ get; set; }
        public int Std { get; set; }
    }
    
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    
    class Solution
    {
        public static Node insert(Node head, int data)
        {
            if (head == null)
                return new Node(data);
            else if (head.next == null)
                head.next = new Node(data);
            else
                insert(head.next, data);

            return head;
        }
    }
}

