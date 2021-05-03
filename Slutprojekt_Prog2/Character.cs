using System;
using System.Collections.Generic;

namespace Slutprojekt_Prog2
{
    public class Character
    {
        //Variabler
        protected string name;
        protected int hp;
        // protected int strength;
        // protected int speed;


        protected void GetHurt(int ammount)
        {
            hp -= ammount;
        }

        //Olika attacker som väljer hur mycket skada attacken gör. 
        protected int LightPunch()
        {
            return 10;
        }
        protected int HeavyPunch()
        {
            return 20;
        }
        protected int Kick()
        {
            return 15;
        }
        //Get set för hp. 
        public int getHp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = Math.Max(value, 0);
            }
        }

    }
}
