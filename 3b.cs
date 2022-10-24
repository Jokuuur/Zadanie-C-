/*int n = 1;
int x;
//Zad.1
Console.WriteLine("\t\tLISTOPAD 2022");
Console.Write("\t");
for (int i = 1; i <= 30; i++)
{
    Console.Write(i + "\t");
    n++;
    if (n % 7 == 0)
    {
        Console.WriteLine();
        n = 0;
    }
}
Console.WriteLine();

//Zad.2
Console.Write("Podaj zakres: ");
x = int.Parse(Console.ReadLine());
for (int i = 1; i <= x; i++)
    if (i % 2 != 0)
    {
        Console.WriteLine($"{i}^2={i * i}");
    }
//Zad.3
for (int i = 1000; i <= 10000; i++)
    if (i % 379 == 0)
    {
        Console.WriteLine(i);
    }
//Zad.4
for (int i = 100; i <= 1000; i++)
    if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
    {
        Console.WriteLine(i);
    }*/
/*//Zad.5
Console.Write("Ile liczb dodam : ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.Write($"Podaj {i + 1} Liczbę: ");
    int liczba = int.Parse(Console.ReadLine());
    int wynik = liczba;
}
Console.WriteLine($"Suma liczb to: {wynik}" );

//Zad.6
Console.Write("Podaj liczby: ");
int ileLiczb = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 2; i <= (ileLiczb * 2); i += 2)
{
    suma += i;
}
Console.WriteLine($"Wynik: {suma}");*/

/*//Zad.7
Console.Write("Podaj liczby: ");
int n = int.Parse(Console.ReadLine());
int sumeczka = 0;
for (int i = 11; i <= (n * 2) + 11; i += 2)
{
    sumeczka += i;
}
Console.WriteLine($"suma to: {sumeczka}");
*/
//Zad.8
Console.Write("Kasa na początku: ");
int n = int.Parse(System.Console.ReadLine());
Console.Write("Podaj lata inwestycji: ");
int x = int.Parse(System.Console.ReadLine());
int suma = n;
for (int i = 0; i < (x * 12); i++)
{
    int y = (suma * 0.06 * 1 / 12f);
    suma = suma + y;
}
Console.WriteLine($"Wynik: {Math.Round(suma, 2)} zł");

//Zad.9
Console.Write("Podaj ilość liczb: ");
n = int.Parse(Console.ReadLine());
x = 21;
y = 0;
for (int i = 0; i <= n; i++)
{
    for (int a = 0; a < i; a += x)
    {
        Console.WriteLine(n);
        y += x;
        x += 100;
    }
}
Console.WriteLine($"Wynik: {suma}");

//Zad.10
for (double i = 1; i <= 1000; i++)
{
    if (i - Math.Floor(i / 10) * 10 == Math.Sqrt(i))
    {
        Console.WriteLine(i);
    }
    else if (i - Math.Floor(i / 100) * 100 == Math.Sqrt(i))
    {
        Console.WriteLine(i);
    }
}