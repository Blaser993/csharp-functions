// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//PROGETTO

Console.Write("Inserisci un numero: ");
int numero = int.Parse(Console.ReadLine());

int quadrato = Quadrato(numero);

Console.WriteLine($"Il quadrato di {numero} è {quadrato}");

Console.WriteLine();

int[] arrayNoto = { 2, 6, 7, 5, 3, 9 };
//Stampare l’array di numeri fornito a video
Console.Write($"ArrayNoto: ");
StampaArray(arrayNoto);
/*Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato 
(Verificare che l’array originale non sia stato modificato quindi ristampare 
nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])*/
int[] arrayNotoQuadro = ElevaArrayAlQuadrato(arrayNoto);
Console.Write($"ArrayNotoQuadro: ");
StampaArray(arrayNotoQuadro);
Console.Write($"ArrayOriginale: ");
StampaArray(arrayNoto);
//Stampare la somma di tutti i numeri
int sommaElementi = sommaElementiArray(arrayNoto);
Console.WriteLine($"La somma degli elementi dell'ultimo array originale è: {sommaElementi}");
//Stampare la somma di tutti i numeri elevati al quadrato
int sommaQuadrati = sommaElementiArray(arrayNotoQuadro);
Console.WriteLine($"La somma degli elementi dell'ultimo array con gli elementi elevati al quadrato è: {sommaQuadrati}");
Console.WriteLine();
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

int sommaElementiArray(int[] array)
{
    int[] arrayCopy = (int[])array.Clone();

    int somma = 0;

    for (int i = 0; i < arrayCopy.Length; i++)
    {
        somma += arrayCopy[i];
    }
    return somma;
}