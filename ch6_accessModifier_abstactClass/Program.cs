using System;

namespace ch6_accessModifier_abstactClass
{
    class Program
    {
        //// Access Modifier
        // public : 내부 / 외부클래스, 파생클래스, 외부 프로젝트에서 접근가능
        // internal : 내부 / 외부클래스, 파생클래스
        // Protected : 내부클래스, 파생클래스 (상속받은 객체에서만 접근가능)
        // private : 내부 클래스
        // protected internal : 내부 / 외부클래스, 외부클래스 중에서 사용하는 클래스가 같은 어셈블리 안에 있을 때 접근가능.
        // -> dll이나 exe파일과 같은 프로그램 결과에서 클래스가 같은 어셈블리 안에 있을 때.


        // struct : 구조체 생성용.
        // 클래스와 달리 상속 불가능, 인터페이스 구현 불가.
        // 자료구조의 안정성이 매우 높은 편. 자료구조 구현에 주로 쓰였다.
        struct Point
        {
            public int x;
            public int y;

            // 생성자
            // 매개변수를 반드시 넣어야 한다.
            public Point(int x, int y)
            {
                this.x = x;
                this.y = x;
            }
        }

        // interface
        // 메소드, property, event, indexer만을 인자로 갖는다
        // 구현부는 상속받은 클래스에서 구현해야 함

        interface IEmployee
        {
            string getName();
            void setName(string name);
            int getCount();
        }
        public class Employee : IEmployee
        {
            public static int numberOfEmployees;
            private string name;
            private int counter;

            public string getName(){return this.name;}
            public void setName(string name) { this.name = name;}
            public int getCount(){return numberOfEmployees;}
        }
        // abstract 클래스
        // 구현부를 생성할 수 있지만, 인스턴스 생성은 불가능한 객체.        // 구현부가 없으면, 추상클래스 상속받은 클래스에서 구현해야 함.        public abstract class abstractEmployee
        {
            protected string name;
            public abstractEmployee(string name) { this.name = name; }
        }
        public class Manager : abstractEmployee
        {
            // 부모 클래스 호출 = base.
            // 부모 클래스의 생성자를 호출해 사용한다는 의미.
            public Manager(string name) : base(name){
                base.name = name;
            }
        }
        static void Main(string[] args)
        {
            // new 사용해서 생성할 수도 있다.
            Point p1 = new Point();
            Point p2 = new Point(10, 10);

            // 구조체는 기본적으로 copy by value. 값에 의한 복사.
            Point p;
            p.x = 10; p.y = 10;
            Console.WriteLine(p.x);
            Point p3 = p;
            p3.x = 11;
            Console.WriteLine(p3.x); // return 11
            Console.WriteLine(p.x); // return 10
        }
    }
}
