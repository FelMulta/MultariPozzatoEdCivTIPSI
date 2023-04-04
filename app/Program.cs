using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdCivicaMultariPozzato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la stringa da cifrare: ");
            string s = Console.ReadLine();
            Console.WriteLine("Inserisci il numero di posizioni da spostare: ");
            int n = int.Parse(Console.ReadLine());

            string risultato = Cifratura(s, n);
            Console.WriteLine(risultato);
        }

        public static string Cifratura(string s, int n)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string risultato = "";

            foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = (posizione + n) % alfabeto.Length;
                    risultato += alfabeto[posizione];
                }
                else
                {
                    risultato += c;
                }
            }
            return risultato;
        }  
    }
}
