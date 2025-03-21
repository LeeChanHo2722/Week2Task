using System;

namespace _12.클래스_심화
{
    interface IAnimals
    {
        void Speek();
    }
    public class Dog : IAnimals
    {
        public void Speek()
        {
            Console.WriteLine("왈왈");
        }
    }
    public class ChanHo : IAnimals
    {
        public void Speek()
        {
            Console.Write("화이팅!");
        }
    }
    class Program
    {
        static void Main()
        {
            IAnimals Mydog = new Dog();
            IAnimals Me = new ChanHo();

            Mydog.Speek();
            Me.Speek();
        }
    }
}
