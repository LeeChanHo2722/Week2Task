using System;

namespace _13.추가_클래스
{
    class Str
    {
        public struct Num
        {
            public int A;
            public int B;

            public Num(int a, int b)
            {
                A = a;
                B = b;
            }
            public void show()
            {
                Console.WriteLine("{0},{1}", A, B);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Str.Num ABC = new Str.Num(10,20);
            ABC.show();
        }
    }
}
