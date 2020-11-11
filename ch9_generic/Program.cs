using System;
using System.Collections.Generic;

namespace ch9_generic
{
    class Program
    {
        // Generic - 일반화라고 이해하면 편함.
        // Generic class - 데이터 타입을 일반화한 클래스
        // Generic method - 데이터 타입을 일반화한 메소드
        // 1. Generic class
        class Human<T>
            // Generic 타입을 제한하는 방법
            // struct 구조인 Generic만 변수로 받도록 선언하면
            // string을 받을 수 없게 된다.
            where T : struct
        {
            public T name;
            public Human(T name){this.name = name;}

        }

        // 2. Generic Method
        public static void Change<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static void TestChange()
        {
            int x = 1; int y = 2;
            Change(ref x, ref y);
            float z = 1.2f; float w = 2.2f;
            Change(ref z, ref w);
            string a = "test"; string b = "test2";
            Change(ref a, ref b);
        }
        // 3. Generic Collection
        // ArrayList, Stack, Queue, Hashtable의 기본타입은 Object.
        // --> 단, object를 매번 형변환하므로 오버헤드가 발생.
        // Generic으로 선언해서 연산속도를 높일 수 있다.

        // List<T>, Stack<T>, Queue<T>, Dictionary<K,V>

        static void Main(string[] args)
        {
            //Human<string> h1 = new Human<string>("test");
            Human<int> h2 = new Human<int>(2);
            Human <float> h3 = new Human<float>(3.2f);


            //// Generic Collection.
            Stack<int> s = new Stack<int>();
            s.Push(3);
            s.Push(4);
            s.Push((int)3.12f); // 3으로 형변환해야만 저장된다.
            while (s.Count != 0) s.Pop();

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict[3] = "test";
            Console.WriteLine(dict.Keys); // 값이 리턴되진 않고 collection객체 반환
            Console.WriteLine(dict.Values); // 값이 리턴되진 않고 collection객체 반환
        }
    }
}
