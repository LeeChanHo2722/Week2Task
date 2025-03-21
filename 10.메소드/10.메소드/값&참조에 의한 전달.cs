/*using System;
namespace _10.메소드
{
    class 값_참조에_의한_전달
    {
        //값에 의한 참조
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void RefSwap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main()
        {
            int a = 3;
            int b = 4;
            Console.WriteLine("before num1 = {0}, num2 = {1}",a,b);
            Swap(a, b);
            Console.WriteLine("after num1 = {0}, num2 = {1}",a,b);
            Console.WriteLine("before ref num1 = {0}, num2 = {1}", a, b);
            RefSwap(ref a, ref b);
            Console.WriteLine("after ref num1 = {0}, num2 = {1}", a, b);
        }
    }
}*/
