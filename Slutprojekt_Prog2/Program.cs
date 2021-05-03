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
            //Skapar en instans av spelaren. Se Player.cs
            Player player = new Player();

            //Lista för att skapa motståndare, se Opponent.cs
            List<Opponent> EnemyList = new List<Opponent>();

            //Lägger till instans av motståndare i listan.
            for (int z = 0; z < 5; z++)
            {
                EnemyList.Add(new Opponent());
                // Console.WriteLine(EnemyList[z].GetName2);
            }

            bool FightActive = true;
            int enemyNumber = 0;

            //Gamestate
            while (FightActive && enemyNumber < 5)
            {
                //skriver ut spelare och motståndarns hp, baserat på nummer. 
                RoundStats(player, EnemyList, enemyNumber);

                //Motståndares hp dras bort baserat på vilket val spelaren gör
                EnemyList[enemyNumber].getHp = EnemyList[enemyNumber].getHp - playerTurn(player);

                //Spelarens hp dras bort baserat på vilken attack som ligger i motståndarens queue.
                player.getHp = player.getHp - EnemyList[enemyNumber].dealDamage;

                //Rensar konsolen
                Console.Clear();

                //Kollar om motståndaren lever, om den dog, går den vidare till nästa
                enemyNumber = CheckEnemyAlive(enemyNumber, EnemyList);

            }
            Console.ReadLine();
        }

        //Skriver ut spelare och motståndarens hp
        static void RoundStats(Player player, List<Opponent> enemy, int enemyNumber)
        {
            Console.WriteLine("player hp: " + player.getHp);
            System.Console.WriteLine("enemy hp: " + enemy[enemyNumber].getHp);
        }

        //Kollar om motståndaren lever, om inte går nummret upp, vilket byter motståndare. 
        static int CheckEnemyAlive(int number, List<Opponent> enemy)
        {
            if(enemy[number].getHp == 0)
            {
                number++;
            }
            return number;
        }
        

        //metod för att visa spelaren stats
        public static void ShowStats(Player spelare)
        {
            spelare.ShowStats();

        }

        //Frågar vilken attack man vill göra
        static int playerTurn(Player spelare)
        {
            Console.WriteLine("What attack?");
            Console.WriteLine("[1] Light punch \n[2] Heavy punch\n[3] Kick ");
            string svar = playerInput(Console.ReadLine());
            if (svar == "1")
            {
                return spelare.ChooseLightPunch();
                
            }
            else if (svar == "2")
            {
                return spelare.ChooseLightPunch();
            }
            else if (svar == "3")
            {
                return spelare.ChooseKick();
            }
            else
            {return 0;}
        }

        //Om svaret är 1 2 eller 3 så blir key false, vilket bryter loopen
        //Om svaret inte är 1 2 eller 3 skrivs ett felmeddelande ut o man får försöka igen. 
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
