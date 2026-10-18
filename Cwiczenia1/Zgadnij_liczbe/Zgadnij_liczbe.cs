var liczba = new Random();
int szukana = liczba.Next(1, 101);

int podanaLiczba = 0;

while (podanaLiczba != szukana)
{
    Console.WriteLine("Zgadnij liczbę od 1 do 100: ");
    podanaLiczba = Convert.ToInt32(Console.ReadLine());

    if (podanaLiczba > szukana)
    {
        Console.WriteLine("Za dużo!");
    }
    else if (podanaLiczba < szukana)
    {
        Console.WriteLine("Za mało!");
    }
    else
    {
        Console.WriteLine("Brawo! Zgadłeś!");
    }
}