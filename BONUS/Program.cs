// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

/*
 * BONUS:
Convertire le funzioni appena dichiarate in funzioni generiche, 
ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, 
ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, 
e dopo di che questi vengono inseriti a mano dall’utente esternamente.
Rieseguire il programma con l’input preso esternamente dall’utente.
 
*/

Console.Write("Inserisci la lunghezza dell'array vuoto: ");
int lunghezza = Convert.ToInt32(Console.ReadLine());

int[] arrayPopolato = CreaArrayPopolato(lunghezza);

Console.Write("Il tuo array:");


StampaArray(arrayPopolato);



//FUNZIONI

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.WriteLine("]");
}

int [] CreaArrayPopolato(int lunghezza)
{
    int[] array = new int[lunghezza]; 

    for (int i = 0; i < lunghezza; i++)
    {
        Console.Write($"Inserisci il valore per l'elemento {i + 1}: ");
        int valore = Convert.ToInt32(Console.ReadLine());
        array[i] = valore; 
    }

    return array;
}



