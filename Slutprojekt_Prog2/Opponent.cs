using System;
using System.Collections.Generic;

namespace Slutprojekt_Prog2
{
    public class Opponent : Character
    {   
        //Skapar en instans av en motståndare som kallar AttackList().
        public Opponent()
        {
            name = RandomizeName();
            hp = 100;
            // strength = 10;
            // speed = 15;
            AttackList();
        }

        private string RandomizeName()
        {
            //Slumpar fram ett namn i arrayen. 
            //skickar sedan tillbaka namnet och sätter namnet på instansen till det. 
            Random generator = new Random();
            //0 - 4
            int r = generator.Next(9);
            string[] nameArray = { "Aob", "Bod", "Cod", "Dod", "Eob", "Fod", "God", "Hod", "Iod", "Jod"};
            string name = nameArray[r];

            return name;
        }

        //Kolla motståndarens namn, används ej. 
        public string GetName2
        {
            get
            {
                return name;
            }
        }

        //Kollar vilket nästa steg i queue är, tar sedan det nummret och skickar tillbaka det
        //Sedan tas den platsen bort, vilket gör att nästa plats i listan kickas fram,
        //vilket gör att nästa slumpade attack kommer fram. 
        public int dealDamage
        {
            get
            {
                return ChooseAttack();
            }
        }

        //AttackList(), är en metod som skapar generiska klassen Queue
        //lägger till olika siffror på skada beroende på vilken ChooseAttack landar på. 
        public void AttackList()
        {
            Queue<int> AttackSequence = new Queue<int>();

            for (int i = 0; i < 25; i++)
            {
                AttackSequence.Enqueue(ChooseAttack());
                // Console.WriteLine(AttackSequence.Peek());
            }

        }

        //Slumpgenerator som slumpar fram 1 2 eller 3.
        //Switchen kollar vilket r hamnar på, vilket skickar kallar på en metod
        //Metoden skickar då tillbaka en nummer, vilket läggs till i listan genom enqueue. 
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
