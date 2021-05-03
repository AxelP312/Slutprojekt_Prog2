using System;
using System.Collections.Generic;

namespace Slutprojekt_Prog2
{
    public class Player : Character
    {
        //Instans av spelaren. Namn + hp
        public Player()
        {
            hp = 1000;
            // strength = 10;
            // speed = 15;
            name ="bob";
        }

        //metod som skriver ut spelarens stats, används dock inte. 
        public void ShowStats()
        {
            Console.WriteLine(name);
            Console.WriteLine(GetHp());
            // Console.WriteLine(GetStrength());
            // Console.WriteLine(GetSpeed());
        }

        //Kallar metoden LightPunch för att få skada på slaget
        public int ChooseLightPunch()
        {
            return LightPunch();
        }

        //Kallar metoden HeavyPunch för att få skada på slaget
        public int ChooseHeavyPunch()
        {
            return HeavyPunch();
        }

        //Kallar metoden Kick för att få skada på slaget
        public int ChooseKick()
        {
            return Kick();
        }

        //GetHP metod för att hämta varabeln hp. 
        private int GetHp()
        {
            return hp;
        }

        // private int GetStrength()
        // {
        //     return strength;
        // }

        // private int GetSpeed()
        // {
        //     return speed;
        // }

    }
}
