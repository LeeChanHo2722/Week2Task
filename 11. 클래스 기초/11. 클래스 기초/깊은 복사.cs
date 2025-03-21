/*using System;
using System.Media;

namespace _11.클래스_기초
{
    public class Person
    {
        public string Name;
        public int Age;

        public void Info()
        {
            Console.WriteLine("그의 이름은 {0}이고 나이는 {1}입니다", Name, Age);
        }
        public Person DeepCopy()
        {
            Person Clone = new Person();
            Clone.Name = Name;
            Clone.Age = Age;

            return Clone;
        }
    }

    class Program
    {
        public static void Main()
        {
            Person chanho = new Person();
            chanho.Name = "이찬호";
            chanho.Age = 18;
            Person Friend = new Person();
            Friend.Name = "김주환";
            Friend.Age = 22;

            Friend = chanho.DeepCopy();
            Friend.Name = "백승한";

            chanho.Info();
            Friend.Info();
        }
    }
}*/