using System;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            void virgola()
            {
                Console.Write(" , ELEMENTO ");
            }



            void StampaArray(int[] array)
            {
                
                Console.Write("[ ");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                    {
                        virgola();
                    }
                    
                }
                
                Console.Write(" ] ");
            }

            int[] numeri = { 2, 6, 7, 5, 3, 9 };
            StampaArray(numeri);






            Console.WriteLine("inserisci un numero");

            
            string input = Console.ReadLine();
            int numero = Convert.ToInt32(input);
            //cosi utilizzo la funzione 
            int quadrato = Quadrato(numero);
            Console.WriteLine($"il numero e {numero} elevato e {quadrato}");

            int Quadrato(int numero)
            {
                int risultato = numero * numero; 
                return risultato;
            }




            Console.Write("array  elevato al quadrato");
            int[] numeriAlQuadrato = ElevaArrayAlQuadrato(numeri);
            StampaArray(numeriAlQuadrato);

            //devo crere un nuovo array calcolando al quadrato l'array numeri , salvandolo in uno nuovo
            int[] ElevaArrayAlQuadrato(int[] array)
            {
                //int[] nuovoArray = {1,2,3,4,5,6,7,8,9};
                int lunghezza = array.Length;
                int[] nuovoArray = new int[lunghezza];


                for (int i = 0; i < lunghezza; i++)
                {
                    nuovoArray[i] = array[i] * array[i];

                }

                return nuovoArray;
            }


            int sommaTotale = sommaElementiArray(numeri);
            Console.WriteLine($"somma di tutti i numeri {sommaTotale}");

            //preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
            int sommaElementiArray(int[] array)
            {
                int somma = 0;
                foreach (int numero in array)
                {
                    somma += numero;
                }
                return somma;
            }



        }
    }
}
