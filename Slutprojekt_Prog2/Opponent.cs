using System;
using System.Collections.Generic;

namespace Slutprojekt_Prog2
{
    public class Opponent : Character
    {
        public Opponent()
        {
            name = RandomizeName();
            hp = 100;
            strength = 10;
            speed = 15;
            CreateAttacks();
        }

        private string RandomizeName()
        {
            Random generator = new Random();
            //0 - 4
            int r = generator.Next(9);
            string[] nameArray = { "Aob", "Bod", "Cod", "Dod", "Eob", "Fod", "God", "Hod", "Iod", "Jod"};
            string name = nameArray[r];

            return name;
        }

        public string GetName2
        {
            get
            {
                return name;
            }
        }
        private void CreateAttacks()
        {
            Queue<int> AttackSequence = new Queue<int>();

            for (int i = 0; i < 25; i++)
            {
                AttackSequence.Enqueue(ChooseAttack());
                // Console.WriteLine(AttackSequence.Peek());
            }

        }
        private int ChooseAttack()
        {

            Random generator = new Random();
            //1-3
            int r = generator.Next(1, 4);

            switch (r)
            {
                case 1:
                    return LightPunch();
                case 2:
                    return HeavyPunch();
                case 3:
                    return Kick();
                default:
                    return 0;
            }
        }

    }
}
