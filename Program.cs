using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrémagique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carré magique");
            Console.WriteLine("------------------------------------------------------------------------\n");
            Console.Write("Hauteur du carré: ");
            int hauteur = Convert.ToInt32(Console.ReadLine());
            Console.Write("Longueur du carré: ");
            int longueur = Convert.ToInt32(Console.ReadLine());
            int[,] tCarre = new int[hauteur, longueur];
            int[] iSomme = new int[2];
            Console.Clear();
            Console.WriteLine("Carré magique");
            Console.WriteLine("------------------------------------------------------------------------\n");
            for (int i = 0; i < hauteur; i++)
            {
                for(int j = 0; j < longueur; j++)
                {
                    Console.Write("Veuillez saisir la valeur de la case {0}/{1}: ", i+1, j+1);
                    tCarre[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("Carré magique");
            Console.WriteLine("------------------------------------------------------------------------\n");
            bool bTest = true;
            for (int i = 0; i < longueur; i++)
            {
                iSomme[0] = iSomme[0] + tCarre[0, i];
                iSomme[1] = iSomme[1] + tCarre[1, i];
            }
            
            for (int i = 1; i < hauteur; i++)
            {
                if (iSomme[0] == iSomme[1])
                {
                    if(i > 1)
                    {
                        iSomme[0] = iSomme[1];
                        iSomme[1] = 0;
                        for (int j = 0; j < longueur; j++)
                        {
                            iSomme[1] = tCarre[i, j] + iSomme[1];
                        }
                    }
                }
                else
                {
                    bTest = false;
                }
                
            }

            for (int i = 0; i < longueur; i++)
            {
                if (iSomme[0] == iSomme[1])
                {
                    iSomme[0] = iSomme[1];
                    iSomme[1] = 0;
                    for (int j = 0; j < hauteur; j++)
                    {
                        iSomme[1] = tCarre[i, j] + iSomme[1];
                    }
                }
                else
                {
                    bTest = false;
                }

            }
            iSomme[1] = 0;
            for (int j = 0; j < hauteur; j++)
            {
                iSomme[1] = tCarre[j, j] + iSomme[1];
            }
            if (iSomme[0] == iSomme[1])
            {
                iSomme[0] = iSomme[1];
                iSomme[1] = 0;
            }
            else
            {
                bTest = false;
            }
            iSomme[1] = 0;
            for (int i = 0; i < hauteur; i++)
            {
                iSomme[1] = tCarre[i, 3-i] + iSomme[1];
            }
            if (iSomme[0] == iSomme[1])
            {
                iSomme[0] = iSomme[1];
                iSomme[1] = 0;
            }
            else
            {
                bTest = false;
            }
            if (bTest == false)
            {
                Console.WriteLine("\nCeci n'est pas un carré parfait.");
            }
            else
            {
                Console.WriteLine("\nCeci est un carré parfait.");
            }
            Console.ReadKey();
        }
    }
}
