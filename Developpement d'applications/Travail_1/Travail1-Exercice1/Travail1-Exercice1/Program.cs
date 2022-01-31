using System;

namespace Travail1_Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Travail #1 - Exercice #1");
            Console.WriteLine("Il y a présentement 2 problèmes à corriger dans le programme suivant");
            Console.WriteLine("1- Identifier les 2 problèmes");
            Console.WriteLine("2- Corriger les 2 problèmes en utilisant la méthode appropriée");
            Console.WriteLine("3- Mettre des commentaires dans votre code pour donner des détails sur le problème et votre correctif");

            int val = 0;

            int[,] tableauVal = new int[999,999];

            for(int x=0; x<999; x++)
            {
                for (int y = 998; y > 0 ; y--) //y doit être égale à 998 et non 999 car le tableau vas de 0 à 998 (taille 999) et non de 1 à 999
                {
                    tableauVal[x, y] = val;
                    val++;
                }
            }
            Console.WriteLine(val);
            Console.WriteLine("..!END!..");
            Console.ReadKey();
        }
    }
}
