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
            for (int z = 0; z < 7; z++)
            {   
                EnemyList.Add(new Opponent());
                Console.WriteLine(EnemyList[z].GetName2);
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

        
    }
}
