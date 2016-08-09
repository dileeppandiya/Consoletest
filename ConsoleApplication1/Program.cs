using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public delegate void Del(int x, string message);
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<student>
            {
                new student() {Name ="dileep", Std=1 },
                new student() { Name = "padniya", Std = 2 }
            };

          
            
            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Std);

            }
            Console.ReadLine();
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

