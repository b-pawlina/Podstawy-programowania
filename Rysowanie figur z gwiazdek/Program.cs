Console.Write("Podaj wysokość trójkąta: ");
int wysokosc = Convert.ToInt32(Console.ReadLine());

if (wysokosc > 0)
{
    for (int i = 1; i <= wysokosc; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Błędna wysokość");
}