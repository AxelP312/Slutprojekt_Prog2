using System;
using System.Collections.Generic;

namespace Slutprojekt_Prog2
{
    public class Character
    {
        protected string name;
        protected int hp;
        protected int strength;
        protected int speed;


        protected void GetHurt(int ammount)
        {
            hp -= ammount;
        }

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
