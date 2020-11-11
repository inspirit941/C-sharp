using System;

namespace ch8_indexer_out
{

    // indexer: 인덱스를 사용해서 인스턴스 내의 데이터에 접근할 수 있도록 하는 property
    // --> property와의 차이점: 해당 접근자가 매개변수를 사용한
    // this[] 형태로 선언. 클래스나 구조체의 인스턴스를 배열처럼 인덱싱이 가능함.

    class Cat
    {
        public int this[int idx] // Indexer 선언부.
        {
            get { return idx*idx; }
            set { Console.WriteLine(idx + "번째 고양이, value : " + value); }
        }
    }

    // out : 다중 반환 시 사용. return은 하나의 값만 반환할 때 사용
    // TryParse() - msdn에서 사용함. 클래스 메소드이며, 리턴값은 실패 시 0을 리턴 (bool)
    // 첫 번째 인자 = 숫자로 변환될 문자열, 두 번째 인자 = out 키워드 붙여 매개변수로 작성
    
    class Program
    {

        
        static void Main(string[] args)
        {
            Cat c = new Cat();
            Console.WriteLine(c[2]); // 배열처럼 사용할 수 있다. return 4
            c[0] = 10; // return 0번째 고양이, value = 10
            Console.WriteLine(c[0]); // return 0


            // out
            int outValue;
            // 키보드로 문자열 입력받아서 tryparse. 결과값은 out 뒤에 정의한 변수에 저장.
            bool result = int.TryParse(Console.ReadLine(), out outValue);
            Console.WriteLine(result); // 숫자 입력시 True, 문자열 입력시 False
            Console.WriteLine(outValue); // 숫자 입력시 숫자값 그대로 반환, 문자열 입력시 0
        }
    }
}
