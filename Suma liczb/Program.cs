Console.Write("Podaj liczbę: ");
int liczba = Convert.ToInt32(Console.ReadLine());

int suma = 0;

if (liczba >= 1)
{
    for (int i = 0; i <= liczba; i++)
    {
        suma += i;
    }
    Console.WriteLine($"Suma liczb od 1 do {liczba} wynosi: {suma}");
}
else
{
    Console.WriteLine("Podana liczba nie jest większa od 1");
}