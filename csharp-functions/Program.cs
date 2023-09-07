// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//PROGETTO

Console.Write("Inserisci un numero: ");
int numero = int.Parse(Console.ReadLine());

int quadrato = Quadrato(numero);

Console.WriteLine($"Il quadrato di {numero} è {quadrato}");


int[] array1 = { 2, 3, 4, 5 };

int[] arrayQuadro = ElevaArrayAlQuadrato(array1);

Console.Write($"dato questo array1: ");
StampaArray(array1);
Console.Write($"moltiplico al quadrato ogni suo elemento ed ottngo il seguente array: ");
StampaArray(arrayQuadro);


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

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayCopy = (int[])array.Clone();

    for (int i = 0; i < arrayCopy.Length; i++)
    {
        arrayCopy[i] = Quadrato(arrayCopy[i]) ;
    }

    return arrayCopy;  

}