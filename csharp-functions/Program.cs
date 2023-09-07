// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//PROGETTO

Console.Write("Inserisci un numero: ");
int numero = int.Parse(Console.ReadLine());

int quadrato = Quadrato(numero);

Console.WriteLine($"Il quadrato di {numero} è {quadrato}");



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

int Quadrato(int numero)
{
    return numero * numero;

    
}