Console.Write("Podaj liczbę: ");
int liczba = Convert.ToInt32(Console.ReadLine());

int liczbaParzysta = 0;
int liczbaNieparzysta = 0;

if (liczba > 0)
{
    Console.Write("Liczby parzyste: ");

    for (int i = 1; i < liczba; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
            liczbaParzysta++;
        }
        else
        {
            liczbaNieparzysta++;
        }
    }

    Console.WriteLine($"\nLiczb parzystych: {liczbaParzysta}");
    Console.WriteLine($"Liczb nieparzystych: {liczbaNieparzysta}");
}
else
{
    Console.WriteLine("Liczba musi być większa od 0");
}