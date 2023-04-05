﻿using System;
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
            Console.WriteLine("Funzione da eseguire: ");
            int smistamento = int.Parse(Console.ReadLine());
            string s, risultato;
            int n, sum  = 0;
            double product = 1.0; 
            switch (smistamento){
                case 1: 
                    Console.WriteLine("Inserisci la stringa da cifrare: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Inserisci il numero di posizioni da spostare: ");
                    n = int.Parse(Console.ReadLine());

                    risultato = Cifratura(s, n);
                    Console.WriteLine(risultato);
                    break;
                case 2:
                    Console.WriteLine("Inserisci la stringa da decifrare: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Inserisci il numero di posizioni da spostare: ");
                    n = int.Parse(Console.ReadLine());

                    risultato = Decifratura(s, n);
                    Console.WriteLine(risultato);
                    break;
                case 3:
                    Console.WriteLine("Inserisci la stringa da decifrare: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Inserisci il numero di posizioni da spostare: ");
                    n = int.Parse(Console.ReadLine());

                    risultato = SostituzioneLettereValori(s, n, sum);
                    Console.WriteLine(risultato);
                    break;
                case 4:
                    Console.WriteLine("Inserisci la stringa da decifrare: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Inserisci il numero di posizioni da spostare: ");
                    n = int.Parse(Console.ReadLine());

                    risultato = SostituzioneLettereValoriDivisione(s, n, product);
                    Console.WriteLine(risultato);
                    break;
            }
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

        public static string Decifratura(string s, int n)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string risultato = "";

            foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = (posizione - n + alfabeto.Length) % alfabeto.Length;
                    risultato += alfabeto[posizione];
                }
                else
                {
                    risultato += c;
                }
            }
            return risultato;
        }
        public static string SostituzioneLettereValori(string s, int n, int sum) 
        {
            foreach (char c in s) 
            {
                int value = (int) char.ToUpper(c) - 64;
                if (value < 1 || value > 26) 
                {
                    Console.WriteLine("La stringa deve contenere solo lettere dell'alfabeto.");
                }
                sum += value;
            }
            int result = sum * n;
            Console.WriteLine("Risultato: " + result);
            string stringResult = result.ToString();
            return  stringResult;
        }

        public static string SostituzioneLettereValoriDivisione(string s, int n, double product)
        {

            return  stringResult;
        }
    }
}
