using System;

namespace Slutprojekt_Prog2
{
    public class Player : Character
    {

        public Player()
        {
            hp = 100;
            strength = 10;
            speed = 15;
        }

        public void ShowStats()
        {
            
            Console.WriteLine(GetHp());
            Console.WriteLine(GetStrength());
            Console.WriteLine(GetSpeed());
        }

        private int GetHp()
        {
            return hp;
        }

        private int GetStrength()
        {
            return strength;
        }

        private int GetSpeed()
        {
            return speed;
        }

    }
}
