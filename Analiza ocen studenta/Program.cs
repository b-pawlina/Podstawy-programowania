Console.Write("Ile ocen chcesz wprowadzić? ");
int liczba_ocen = Convert.ToInt32(Console.ReadLine());

double oceny = 0;
int najwyzszaOcena = 0;
int najnizszaOcena = 0;
int ocenyPozytywne = 0;

if (liczba_ocen > 0)
{
    for (int i = 0; i < liczba_ocen; i++)
    {
        Console.Write("Podaj ocenę: ");
        int aktualnaOcena = Convert.ToInt32(Console.ReadLine());
        if (aktualnaOcena < 7 && aktualnaOcena > 0)
        {
            oceny += aktualnaOcena;

            if (aktualnaOcena > najwyzszaOcena)
            {
                najwyzszaOcena = aktualnaOcena;
            }

            if (aktualnaOcena < najnizszaOcena || najnizszaOcena == 0)
            {
                najnizszaOcena = aktualnaOcena;
            }

            if (aktualnaOcena >= 3)
            {
                ocenyPozytywne++;
            }
        }
        else
        {
            Console.WriteLine("Nie ma takiej oceny");
        }
    }
    double srednia = oceny / liczba_ocen;
    Console.WriteLine($"\nŚrednia: {srednia.ToString("F2")}");
    Console.WriteLine($"Największa ocena: {najwyzszaOcena}");
    Console.WriteLine($"Najniższa ocena: {najnizszaOcena}");
    Console.WriteLine($"Liczba ocen pozytywnych: {ocenyPozytywne}");
}
else
{
    Console.WriteLine("Nie podano żadnej oceny");
}