using System;
using System.Collections;

namespace ch7_property_array_collection
{
    class Accessor
    {
        // property
        // Accessor - get, set
        // value - 접근자 사용 시 사용되는 암묵적 매개변수
        private int x;
        public int propertyOfX // property 형태
            // propertyOfX로 접근하면, 실제로는 private로 선언된 x값에 접근할 수 있음.
            // private 변수는 숨기고, property 형태로 접근할 수 있음.
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        // 더 간결한 형태의 property - 자동구현 방식. C# 3.0부터 지원
        // autoImplement라는 이름의 변수 + getter, setter까지 내부적으로 구현해 사용.
        public int autoImplement { get; set; }
    }
    // 인터페이스에도 적용 가능
    // 이 경우, 이걸 구현하는 구현체에서 get, set 구현부를 정의해야 한다.
    interface PropertyInterface
    {
        public string Name{ get;set; } // read / write 가능한 property
        public int Counter { get; } // read만 가능한 Property
    }

    // 접근제한자를 붙이지 않으면 private이 붙는다.
    class PropertyInterfaceImpl : PropertyInterface
    {
        public string Name {
            get { return Name; }
            set { Name = value; }
        }
        public int Counter {get { return Counter; } }
    }

    abstract class Shape
    {
        public abstract double Area { get; set; }
    }
    class Square : Shape
    {
        public double side;
        public Square(double side) { this.side = side; }
        public override double Area
        {
            get { return side * side; }
            set { Math.Sqrt(value); }
        }
    }

    // 배열
    // 컬렉션 : 같은 성격을 띄는 자료의 set을 담는 구조
    // -> arraylist, stack, queue, hashtable 등

    class Program
    {   
        static void Main(string[] args)
        {
            Accessor accessor = new Accessor();
            accessor.propertyOfX = 1000; // property의 set 접근자를 활용한 값 지정
            Console.WriteLine(accessor.propertyOfX); // get 접근자로 값 출력
            accessor.autoImplement = 10;

            /// 배열
            int[] locker = new int[5];
            locker[0] = 1;
            locker[1] = 3;
            for (int i =0; i < locker.Length; i++)
            {
                Console.WriteLine(locker[i]);
            }
            Console.WriteLine("-----");
            foreach (int i in locker)
            {
                Console.WriteLine(i);
            }
            // 2차원 배열
            // 3행 2열
            int[,] array2d = new int[3, 2] { { 9, 10 }, { 3, 33 }, { 10, 100 } };
            // 가변배열 선언
            int[][] array = new int[3][];
            array[0] = new int[4] { 1, 2, 3, 4 };
            array[2] = new int[] { 1, 2, 3 };

            // collection
            // 1. arraylist
            ArrayList arraylist = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                arraylist.Add(i);
                // RemoveAt(idx)
                // Insert(idx, value)
            }
            foreach (int j in arraylist) Console.WriteLine(j);
            // 2. stack
            Stack s = new Stack();
            s.Push(1);
            while (s.Count != 0) Console.WriteLine(s.Pop());

            // 3. queue
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            var pop = q.Dequeue();
            Console.WriteLine(pop);
            Console.WriteLine(q.Count);

            // 4. hashtable
            Hashtable t = new Hashtable();
            t[1] = "v1";
            t["test"] = 1;
            Console.WriteLine(t["test"].ToString()+ " " + t[1].ToString());

        }
    }
}
