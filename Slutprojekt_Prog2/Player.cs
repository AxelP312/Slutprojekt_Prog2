using System;
using System.Collections.Generic;

namespace Slutprojekt_Prog2
{
    public class Player : Character
    {

        public Player()
        {
            hp = 100;
            strength = 10;
            speed = 15;
            name ="bob";
        }

        public void ShowStats()
        {
            Console.WriteLine(name);
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
