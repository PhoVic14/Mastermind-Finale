using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mastermindFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string combinaison;
            int[] combi;
            int[] propo;

            CombiSecretOrdi(out combi);

            Afficher(combi);
        }
        static void CombiSecretOrdi(out int[] combi) //l'ordinateur choisi ses chiffres 
        {
            Random rnd = new Random();
            combi = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                int nombre = rnd.Next(1, 7);
                combi[i] = nombre;
            }

            static void Afficher(int[] combi) //Affiche le tableau
            {
                for (int i = 0; i <= 3; i++)
                    Console.Write(combi[i]);
            }
            Console.WriteLine();
        }
        static void StringToArray(string proposition, out int[] propo)
        {
            propo = new int[4];

            for (int i = 0; i <= 3; i++) (
                     propo[i] = int.Parse(proposition[i].ToString());


            static void PionsRouges(int[] propo, int[] combi) //les pions rouges
            {
                int nombrePionsRouges;
                nombrePionsRouges = 0;
                for (int i = 0; i <= 3; i++)
                {
                    if (propo[i] == combi[i]) (
            nombrePionsRouges++;
                    propo[i] = -1;
                    combi[i] = -2;
                }

                static void PionsBlancs(int[] propo, int[] combi) //les pions blanc 
                {
                    int nombrePionsBlanc;
                    nombrePionsBlanc = 0;
                    for (int i = 0; i <= 3; i++)
                    {
                        if (propo[i] == combi[i]) (
               nombrePionsBlanc++;
                        propo[i] = -1;
                        combi[i] = -2;
                    }
                }
            }

        }
    }
