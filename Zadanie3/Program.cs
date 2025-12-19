// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj kolejno liczby całkowite i zakończ 0");
try
{
    int[] tablica = new int[0];
    int i = 1;
    while (true)
    {
        Console.Write($"Podaj {i++} liczbę: ");
        int a = int.Parse(Console.ReadLine());
        if (a == 0)
            break;
        tablica.Append(a);
    }
    if (tablica.Length == 0)
        throw new Exception();

    //Obliczenie min i max
    int xmin = 0;
    int xmax = 0;
    for (i = 0; i < tablica.Length; i++)
    {
        if (i == 0)
        {
            xmin = tablica[i];
            xmax = xmin;
        }
        else
        {
            if (xmin > tablica[i])
                xmin = tablica[i];
            if (xmax < tablica[i])
                xmax = tablica[i];
        }
    }

    //Obliczenie sumy min i max
    Console.WriteLine($"Suma liczby minimalnej {xmin} i maksymalnej {xmax} wynosi {xmin + xmax}");
    Console.WriteLine($"Średnia liczby minimalnej {xmin} i maksymalnej {xmax} wynosi {((double)xmin +(double)xmax)/2d}");
}
catch
{
    Console.WriteLine("Należy podać liczby całkowite i zakończyć zerem. Musi być conajmniej 1 element");
}
