Console.WriteLine("Wprowadź swoje imię!");
var imie = Console.ReadLine();

Console.WriteLine("Podaj pierwszą liczbę: ");
int ocena1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę: ");
int ocena2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj trzecią liczbę: ");
int ocena3 = Convert.ToInt32(Console.ReadLine());

decimal srednia = Convert.ToDecimal(ocena1 + ocena2 + ocena3) / 3;
Console.WriteLine($"{imie}, Twoja średnia to: {srednia.ToString("F2")}");

if (srednia >= 3)
{
    Console.WriteLine("Zaliczone!");
}
else
{
    Console.WriteLine("Niezaliczone");
}