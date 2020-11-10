using System;

namespace ch4_method_parameter
{
    class testClass
    {
        // field, method 정의 가능.
        // 메소드 정의, input 필드 정의도 자바와 매우 비슷하다.
        public static string getString(string input)
        {
            return input;
        }
    }

    class Program
    {
        public static void Nice()
        {
            Console.WriteLine("static void method");
        }
        // call by value
        static void CallByValue(int c, int d)
        {
            int t;
            t = c;
            c = d;
            d = t;
        }

        // call by reference 
        static void CallByRef(ref int c, ref int d)
        {
            // c와 d는 input으로 들어온 값 a, b를 각각 참조.
            int t; 
            t = c; // 메인메소드의 a값을 지역변수 t에 할당.
            c = d; // 메인메소드 b값을 메인메소드 변수 a에 대입.
            // 따라서 이 경우, 메인메소드의 a값 자체가 바뀐다.
            d = t; // 지역변수 t에 정의된 메인메소드의 a값 (55)을 b에 대입
        }
        // named parameter + optional
        static void NamedParameter(string name1, string name2 = "")
        {
            Console.WriteLine("{0} {1}", name1, name2);
        }

        static void Main(string[] args)
        {
            Program.Nice();
            // 매개변수 전달방식
            // call by Reference -> ref 키워드를 사용한다.
            int a = 55; int b = -9;
            CallByValue(a, b);
            Console.WriteLine(a.ToString() +" " + b.ToString());
            // return 55, -9
            a = 55; b = -9;
            CallByRef(ref a, ref b);
            Console.WriteLine(a.ToString() + " " + b.ToString());
            // return -9, 55

            // named Parameter. 순서대로 입력하지 않아도 변수명을 지정하면 그대로 적용됨
            NamedParameter(name2: "test2", name1: "test");
            // return "test test2"
            // name2는, 따로 파라미터 받지 않으면 디폴트로 ""가 할당됨.
            // optional parameter는 모든 필수 매개변수 뒤에 선언되어야 한다.

        }
    }
}
