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
            string s, risultato;
            int n;
            int sum  = 0;
            double product = 1.0; 
            int contatore = 0;
            bool chiuso = false;
            do
            {
                Console.WriteLine("Funzione da eseguire: ");
                int smistamento = int.Parse(Console.ReadLine());
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
                    case 5:
                        Console.WriteLine("Inserisci la stringa da decifrare: ");
                        s = Console.ReadLine();
                        Console.WriteLine("Inserisci il numero di posizioni da spostare: ");
                        n = int.Parse(Console.ReadLine());

                        risultato = Punto5(s, n, sum, product);
                        Console.WriteLine(risultato);
                        break;
                    case 6:
                        Console.WriteLine("Hai usato la funzione 5 " + contatore + " volte.");
                        break;
                    case 7:

                        break;
                }
            

                static string Cifratura(string s, int n)
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

                static string Decifratura(string s, int n)
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
                static string SostituzioneLettereValori(string s, int n, int sum) 
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

                static string SostituzioneLettereValoriDivisione(string s, int n, double product)
                {
                    foreach (char c in s) 
                    {
                        int value = (int) char.ToUpper(c) - 64;
                        if (value < 1 || value > 26) 
                        {
                            Console.WriteLine("La stringa deve contenere solo lettere dell'alfabeto.");
                        }
                        product *= value;
                    }
                    double result = Math.Ceiling(product / n);

                    Console.WriteLine("Risultato: " + result);
                    string stringResult = result.ToString();
                    return  stringResult;
                }

                string Punto5(string s, int n, int sum, double product)
                {
                    if(n % 2 == 0)
                    {
                        contatore++;
                        string risultato = SostituzioneLettereValori(s, n, sum);
                        return risultato;
                    }
                    else
                    {
                        contatore++;
                        string risultato = SostituzioneLettereValoriDivisione(s, n, product);
                        return risultato;
                    }
                }
                Console.WriteLine("Vuoi continuare l'esecuzione? (s/n)-> ");
                char verifica = char.Parse(Console.ReadLine());
                if (verifica == 's')
                {
                    chiuso = false;
                }else{
                    chiuso = true;
                }
            }while(!chiuso);      
        }
    }
}
