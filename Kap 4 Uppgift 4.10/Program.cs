using System;
namespace Uppgift4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop = "j";

            //Mother loop
            do
            {
                game(); //Själva spelkoden

                //Köra igen?
                Console.WriteLine("\nVill du testa igen? [j]a eller [n]ej?");
                loop = Console.ReadLine().ToLower();
            }
            while (loop != "n");
        }
        
        //Själva programmet
        static void game()
        {
            //Frågor och variabler 
            Console.WriteLine("Hur många X per grupp?");
            long XPerGroup = long.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O per grupp?");
            long OPerGroup = long.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O-mönster per rad?");
            long OPatterns = long.Parse(Console.ReadLine());

            Console.WriteLine("Hur många rader?");
            long rows = long.Parse(Console.ReadLine());

            //Loopen för rader
            for (int i = 0; i < rows; i++)
            {

                //Loopen som skriver ut per rad
                for (int j = 1; j <= (OPatterns * 2 + 1)/*Antal saker som skrivs per rad följer ett mönster som är lika med antalet OPatterns*2+1*/; j++)
                {

                    //Om j är ett jämnt tal skrivs X ut
                    if (j % 2 == 1)
                    {
                        for (int k = 0; k < XPerGroup; k++) //Antal X per rad
                        {
                            Console.Write("X");
                        }
                    }

                    //Om j är jämnt ska O skrivas ut
                    else if (j % 2 == 0)
                    {
                        for (int k = 0; k < OPerGroup; k++) //Antal O per rad
                        {
                            Console.Write("O");
                        }
                    }

                    //-skrivs efter alla X- och O-mönster förutom den sista
                    if (j != (OPatterns * 2 + 1))
                    {
                        Console.Write("-");
                    }
                }

                //Ny rad (om det inte är den sista raden
                Console.WriteLine();
            }
        }
    }
}