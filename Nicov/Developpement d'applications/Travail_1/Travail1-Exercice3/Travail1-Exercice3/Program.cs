using System;

namespace Travail1_Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Travail #1 - Exercice #3");
            Console.WriteLine("Il y a présentement 2 problèmes à corriger dans le programme suivant");
            Console.WriteLine("1- Identifier les 2 problèmes");
            Console.WriteLine("2- Corriger les 2 problèmes en utilisant la méthode appropriée");
            Console.WriteLine("3- Mettre des commentaires dans votre code pour donner des détails sur le problème et votre correctif");

            int x = 0;
            bool validSaisie = false,
                respetConsigne = false;
            int nombre;
             
            do
            {
                do
                {
                    Console.WriteLine("\n Entrez un nombre entre 1 et 100");
                    String saisie = Console.ReadLine();
                    validSaisie = Int32.TryParse(saisie, out nombre);
                } while (!validSaisie);

                respetConsigne = nombre < 1 ? false : nombre > 100 ? false : true; //Le nombre entré doit être compris entre 1 et 100 et non 0 et 100, puis les true et false ont été inversés à la fin

                if (!respetConsigne)
                    Console.WriteLine("Vous avez entré un nombre mais vous n'avez pas respecté les directives...!");

            } while (!respetConsigne);

            Console.WriteLine("..!END!..");
            Console.ReadKey();
        }
    }
}
