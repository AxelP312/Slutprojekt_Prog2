using System.Xml;
using System.Security;
using System;
using System.Collections.Generic;

namespace Slutprojekt_Prog2
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();

            //Lista för att skapa motståndare
            List<Opponent> EnemyList = new List<Opponent>();
            //Lägger till instans av motståndare i listan.
            for (int z = 0; z < 5; z++)
            {
                EnemyList.Add(new Opponent());
                // Console.WriteLine(EnemyList[z].GetName2);
            }

            Console.WriteLine("Start Combat");
            bool FightActive = true;
            int round = 1;
            while (FightActive)
            {
                //Spelarens tur att slå
                EnemyList[0].getHp = EnemyList[0].getHp - playerTurn(player);

                //Motståndarens hp
                Console.WriteLine("enemy hp: " + EnemyList[0].getHp);

                //Motståndares tur att slå
                player.getHp = player.getHp - EnemyList[0].dealDamage;
                
                //spelarens hp
                Console.WriteLine("player hp: " + player.getHp);

                //ökar round nummret
                round++;
                Console.WriteLine("Round: " + round);

            }

            //Skriver ut spelarens "Stats" 
            ShowStats(player);

            Console.ReadLine();
        }

        //metod för att visa spelaren stats
        public static void ShowStats(Player spelare)
        {
            spelare.ShowStats();

        }

        static int playerTurn(Player spelare)
        {
            Console.WriteLine("What attack?");
            Console.WriteLine("[1] Light punch \n[2] Heavy punch\n[3] Kick ");
            string svar = playerInput(Console.ReadLine());
            if (svar == "1")
            {
                return spelare.ChoseLightPunch();
                
            }
            else if (svar == "2")
            {
                return spelare.ChoseLightPunch();
            }
            else if (svar == "3")
            {
                return spelare.ChoseKick();
            }
            else
            {return 0;}
        }

        static string playerInput(string svar)
        {
            bool key = true;
            while (key == true)
            {
                if (svar == "1" || svar == "2" || svar == "3")
                {
                    key = false;
                }
                else
                {
                    System.Console.WriteLine("Write [1], [2] or [3]");
                    svar = Console.ReadLine();
                }
            }
            return svar;

        }
    }
}
