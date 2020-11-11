using System;

namespace ch5_OOP
{
    class Animal
    {
        public virtual void Eat(string food)
        {
            Console.WriteLine(food + " eat");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("animal sleep");
        }
    }

    // 상속 - 자식클래스 : 부모클래스 형태로 선언.
    // 자바의 final에 대응되는 제한자 - sealed
    // 클래스 앞에 선언될 경우 해당 클래스는 상속될 수 없음.
    class Human : Animal

    {
        // 생성자
        public Human()
        {
            name = "";
            age = 0;
        }
        // 생성자 오버로딩
        public Human(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        // 소멸자
        ~Human()
        {
            Console.WriteLine("Destructor activated");
        }

        // 필드
        public string name;
        public int age;

        

        // 메소드
        public void Walk()
        {
            Console.WriteLine("walking...");
        }
        // 메소드 오버라이드
        // 상위 클래스에는 virtual, 자식클래스에는 override를 붙여야 한다.
        public override void Eat(string food)
        {
            Console.WriteLine(food + " intake by human");
        }

        // 메소드 오버라이드 + final 개념의 접근제한자
        // 누군가 이 클래스를 상속받아도, sleep 메소드는 오버라이드 불가능
        // 일단 부모클래스의 메소드를 오버라이드 한 뒤에야 sealed 접근제한자를 붙일 수 있다.
        // 왜지
        public override sealed void Sleep()
        {
            Console.WriteLine("sealed sleep in human");
        }
        // deep / shallow copy
        // 일반적으로는 shallow copy. 힙 영역의 주소를 참조하는 복사
        // deep copy는 힙 영역에 메모리공간을 확보한 뒤 해당 공간에 복사하는 것.


    }
    class TestCopy
    {
        public int a;
        public int b;
        // hard copy를 위한 메소드
        public TestCopy hardCopy()
        {
            var temp = new TestCopy();
            temp.a = this.a;
            temp.b = this.b;
            return temp;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var test1 = new Human("test", 1);
            Console.WriteLine(test1.age);
            Console.WriteLine(test1.name);
            test1.Eat("food"); // return "food intake by human"

            // shallow copy
            var obj1 = new TestCopy();
            obj1.a = 1;
            obj1.b = 2;
            Console.WriteLine(obj1.a); // return 1
            var obj2 = obj1;
            obj2.a = 2;
            Console.WriteLine(obj2.a); // return 2
            Console.WriteLine(obj1.a); // return 2

            obj1.a = 1;
            obj1.b = 2;
            obj2 = obj1.hardCopy();
            Console.WriteLine(obj2.a);
            
        }
    }
}
