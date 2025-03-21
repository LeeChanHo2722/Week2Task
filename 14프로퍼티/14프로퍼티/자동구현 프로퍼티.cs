using System;

namespace _14프로퍼티
{
    public class Player
    {
        public int CurrentHp
        {
            get; set;
        }
        public string ID
        {
            get; set;
        }
    }
    class program
    {
        static void Main()
        {
            Player player01 = new Player();
            player01.ID = "이찬호";
            player01.CurrentHp = 100;
            Console.WriteLine("ID = {0}, HP = {1}",player01.ID,player01.CurrentHp);
        }
    }
}
