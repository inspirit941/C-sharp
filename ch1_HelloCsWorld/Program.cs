using System;


// namespace : 해당 프로젝트의 폴더 생성 & 하위 소스코드 저장.
namespace HelloCsWorld
{
    class Program
    {
        enum Human { MAN, WOMAN = 3 } // 열거식. 중복값을 지정할 수 없다.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // cli에서 실행할 때
            // HelloCsWorld 문자열
            // 형태로 실행하면 문자열이 인자값으로 넘어간다.
            //Console.WriteLine("{0} {1}", args[0], args.Length);

            // 자료형
            //// 정수형
            // 1. byte / sbyte (부호 없음 / 있음) - 1바이트.
            // byte는 0 ~ 255 (2^8 - 1)까지 표현 가능.
            // sbyte는 -128 ~ 127
            byte a = 100;
            sbyte b = -128;
            Console.WriteLine(a.ToString() + b);

            // 2. short / ushort (unsigned) - 2바이트
            // 3. int / uint - 4바이트
            // 4. long / ulong - 8바이트

            //// 실수형
            // 부동소수점 float - 4바이트, double - 8바이트
            float f = 3.14f;
            double d = 3.14;
            Console.WriteLine(f / 3);
            Console.WriteLine(d / 3);

            //// 문자열
            // char, string
            char c = 'c';
            string str = "test123";

            //// 논리형 - 1바이트. true / false
            /// &&
            bool t = true;
            var ff = false;
            Console.WriteLine(t || ff);

            // 값 형식 - 스택 메모리공간 사용
            // 참조형식 - heap 메모리공간, GC 사용해 값 해제.
            int value = 55;
            object obj = "test";
            Console.WriteLine("{0} {1}", value, obj);

            // 타입캐스팅. 큰 값 -> 작은 값은 불가능. 
            int toInt;
            toInt = a; // byte to int
            // byte a = (byte) 30000; -> overflow. 컴파일 에러가 나진 않음.
            // 소수 -> 정수 변환 시, 소수부분은 잘려나간다.
            int ftoInt = (int)f;
            Console.WriteLine(ftoInt);

            // 열거형 - enumeration (enum). 선택의 폭을 제한하는 역할
            // 클래스 내부, 메소드 외부에 정의한다. 이 경우 main메소드 바깥.
            Console.WriteLine(Human.MAN);
            // 타입캐스팅으로 정수값 리턴 가능. 
            Console.WriteLine((int)Human.WOMAN); // returrn 3

            // var로 변수 선언 시, 변수 선언과 동시에 초기화해야 한다.
            var varTest = 100;
            var varTest2 = "String";
            // object 타입으로 선언할 경우, 참조하는 변수 타입에 맞게 자동 타입캐스팅
            // var는 초기화 시점에서 적합한 자료형으로 선언됨.
            object o = 1;
            Console.WriteLine(o.GetType()); // return int32
            o = "test";
            Console.WriteLine(o.GetType()); // return String
            o = 1.1;
            Console.WriteLine(o.GetType()); // return Double
        }
    }
}
