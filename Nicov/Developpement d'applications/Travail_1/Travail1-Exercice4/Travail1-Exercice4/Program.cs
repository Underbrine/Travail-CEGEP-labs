using System;

namespace Travail1_Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Travail #1 - Exercice #4");
            Console.WriteLine("Il y a présentement une multitude de problèmes à corriger dans le programme suivant");
            Console.WriteLine("1- Identifier les problèmes");
            Console.WriteLine("2- Corriger les problèmes en utilisant la méthode appropriée");
            Console.WriteLine("3- Mettre des commentaires dans votre code pour donner des détails sur le problème et votre correctif");

            int[,] tictactoeGrid = new int[3, 3];

            InitialiseRandomInitialState(ref tictactoeGrid);

            if (IsWinner(tictactoeGrid) != 0)
                Console.WriteLine("Le gagnant est: " + IsWinner(tictactoeGrid));

            Console.WriteLine("\n 4- Que manquerait-il pour permettre de faire un jeu fonctionnel ou il est possible de jouer? \n");

            Console.WriteLine("..!END!..");
            Console.ReadKey();
        }

        static void InitialiseRandomInitialState(ref int[,] tttGrid)
        {
            var aleatoire = new Random();
            int combienCoups = aleatoire.Next(2, 9);
            bool tour = false;
            int position = 0;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    tttGrid[x, y] = 0;
                }
            }

            for (int x = 0; x < combienCoups; x++)
            {
                do
                {
                    position = aleatoire.Next(0, 8);
                } while (tttGrid[position / 3, position % 3] != 0);

                tttGrid[position / 3, position % 3] = tour == true ? 1 : 2;
            }
        }

        static int IsWinner(int[,] tttGrid)
        {
            int winner = 0;
            bool win = false;
            int j;

            for (int i = 0; i < 2; i++)
            {
                win = true;
                for (j = 0; j < 2; j++)//La case 3 n'existe pas il faut donc vérifier que celle ci ne soit pas accédée
                {
                    if (tttGrid[i, j] != tttGrid[i, j + 1]) 
                        win = false;
                }
                if (win)
                    return tttGrid[i, j];
            }

            for (int i = 0; i < 2; i++) //La case 3 n'existe pas il faut donc vérifier que celle ci ne soit pas accédée
            {
                win = true;
                for (j = 0; j < 2; j++)
                {
                    if (tttGrid[j, i] != tttGrid[j, i + 1])
                        win = false;
                }
                if (win)
                    return tttGrid[i, j];
            }

            return winner;
        }
    }
}
