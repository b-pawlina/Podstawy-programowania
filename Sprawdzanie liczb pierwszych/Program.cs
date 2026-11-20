Console.Write("Podaj liczbę: ");
int liczba = Convert.ToInt32(Console.ReadLine());

if (liczba >= 1)
{
    if (liczba % 2 == 0)
    {
        Console.WriteLine($"{liczba} nie jest liczbą pierwszą.");
    }
    else
    {
        Console.WriteLine($"{liczba} jest liczbą pierwszą.");
    }
}
else
{
    Console.WriteLine("Liczba musi być większa od 1");
}