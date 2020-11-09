using System;

namespace ch2_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기본 연산자 - +, -, *, /, %
            int a = 10;
            Console.WriteLine(a++); // a 출력 후 +_1
            Console.WriteLine(++a); // +1 수행 후 a 출력
            // +=, -=, *=, /=, %= 등도 사용 가능.

            // 삼항연산자 (조건연산자).
            // 조건 ? true일경우 실행값 : false일 경우 실행값.
            int x = 5; int y = 7;
            int z;
            z = (x > y) ? x : y;
            Console.WriteLine(z); // return 7

            // 논리연산자 !, &&, ||
            // 비트연산자 : 이진수 형태, 자료형 타입을 이해해야 사용 가능
            x = 61;
            y = 55;
            // 61은 이진수로 111101.
            Console.WriteLine(x << 2); // return 11110100(2) = 244 리턴.
            Console.WriteLine(x >> 2); // return 1111 = 15 리턴. 옮길 때마다 /2 효과
            // & : 이진수의 0과 1값을 각 자릿수마다 둘다 1이면 1, 둘다 0이면 0 리턴
            // | : &처럼 작동하되, 한쪽이 1이면 1 리/
            // ^ : XOR연산.
            // ~ : 하나의 이진수의 0과 1을 전부 반전시킨다.
            // ~로 이진수 비트를 전부 반전시킨 걸 "1의 보수",
            // 1의 보수에 +1한 값을 "2의 보수" 라고 한다.
            Console.WriteLine(~x); // return -62

            // formatting
            Console.WriteLine("{0:X8} {1:X8}", x, y); // 16진수 8자리 표현.

        }
    }
}
