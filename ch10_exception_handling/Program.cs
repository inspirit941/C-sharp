using System;

namespace ch10_exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[4];
            arr[0] = input;arr[1] = 2; arr[3] = 3;
            try
            {
                arr[4] = 4;
                // 예외 생성
                throw new Exception();
            } catch(Exception e)
            {
                var err = e.StackTrace;
                Console.WriteLine(e.Message);
            } finally
            {
                Console.WriteLine("finally");
            }
            

        }
    }
}
