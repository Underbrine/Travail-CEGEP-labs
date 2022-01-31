using System;

namespace Travail1_Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Travail #1 - Exercice #2");
            Console.WriteLine("Il y a présentement au moins 2 problèmes à corriger dans le programme suivant");
            Console.WriteLine("1- Identifier les problèmes");
            Console.WriteLine("2- Corriger les problèmes en utilisant la méthode appropriée");
            Console.WriteLine("3- Mettre des commentaires dans votre code pour donner des détails sur le problème et votre correctif");

            //String nombre; //Cette variable était inutile car il suffisait d'utiliser celle de la boucle (de plus on devait changer le string en int pour éviter les conevrsions inutiles)

            for (int x=0; x<10000; x++)
            {
                //nombre = x.ToString();

                if (IsSquare(x))
                {
                    Console.WriteLine(CalculerRacine(x));
                    Console.WriteLine("C'est un carré parfait");
                }
                /*else
                {
                    Console.WriteLine("Ce n'est pas un carré parfait");
                }*/
            }
            
            Console.WriteLine("..!END!..");
            Console.ReadKey();
        }

        static double CalculerRacine(int nombre) //La fonction renvoyait un booléen alors qu'il fallait renvoyer le résultat de la fonction racine
        {
            //bool result = false;
            //int val = 0;

            //result = Int32.TryParse(nombre, out val);
            //val = nombre;
            return Math.Sqrt(nombre);

            //return result;
        }

        static bool IsSquare(int nombre) //L'argument devait être un int plutôt qu'un string pour éviter des conversions inutiles
        {
            //bool result = true;
            //int val = nombre; //Variable inutile

            //result = Int32.TryParse(nombre, out val);

            if (Math.Sqrt(nombre) % 2 != 0) //Il fallait faire modulo 2 et non 1 pour trouver les carré parfait
                return false; //Doit retourner faux si il y a un reste à la division

            return true;
        }
    }
}
