Console.Write("Podaj liczbę: ");
int liczba = Convert.ToInt32(Console.ReadLine());

int cyfra = 0;

while (cyfra < 10)
{
    cyfra++;
    int suma = liczba * cyfra;
    Console.WriteLine($"{liczba} x {cyfra} = {suma}");
}