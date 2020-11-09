using System;

namespace ch3_for_if_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // if, else if, else 형태.
            // for, while 문법은 평이하고, do while문도 있음.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            while (true)
            {
                break;
            }
            // foreach : 컬렉션 객체를 다루기 위한 용도
            string[] strs = { "a", "b", "c" };
            foreach (string i in strs)
            {
                Console.WriteLine(i);
            }

            // console에서 입력값 받기
            var y = Console.ReadLine();
            // String to int
            int x = int.Parse(y);
            Console.WriteLine(x);


        }
    }
}
