    //Zadanie 1
    
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if((a+b)%2==0)
      Console.WriteLine("TAK");
    else
      Console.WriteLine("NIE");

    //zadanie 2

    a2 = int.Parse(Console.ReadLine());
    float g = int.Parse(Console.ReadLine());
    if(((a2+g)/2)>Math.Sqrt(a2*g))
      Console.WriteLine("TAK");
    else
      Console.WriteLine("NIE");

    //zadanie 3

    int k = int.Parse(Console.ReadLine());
    int l = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    if(k==l)
      Console.WriteLine("k=l");
    else if(k==m)
      Console.WriteLine("k=m");
      else if(l==m)
        Console.WriteLine("l=m");
        else
          Console.WriteLine("Zadna liczba nie jest rowna");

    //zadanie 4

    a3 = int.Parse(Console.ReadLine());
    b3 = int.Parse(Console.ReadLine());
    int c3 = int.Parse(Console.ReadLine());
    int d3 = int.Parse(Console.ReadLine());
    int min = a3;
    if(b3<min)
      min=b3;
    if(c<najmniejsza)
      min=c3;
    if(d<najmniejsza)
      min=d3;
    Console.Write("Minimalna to :  ");
    Console.WriteLine(min);

    //zadanie 5

    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    if((a3+b3>c3) && (a3+c3)>b3 && (b3+c3)>a3)
      Console.WriteLine("TAK");
    else
      Console.WriteLine("NIE");

    //zadanie 6

    a4 = int.Parse(Console.ReadLine());
    b4 = int.Parse(Console.ReadLine());
    c4 = int.Parse(Console.ReadLine());
    int Najkrotszy = a4;
    int Sredni = b4;
    int Dlugi = c4;
    if(a4>b4 && a4>c4)
    {
      Najkrotszy = b4;
      Sredni = c4;
      Dlugi = a4;
    }
    else if(b4>a4 && b4>c4)
    {
      Najkrotszy = a4;
      Sredni = c4;
      Dlugi = b4;
    }
    Console.WriteLine(Math.Pow(3, 2));
    if(Math.Pow(najkrutszy_bok_1, 2)+Math.Pow(najkrutszy_bok_2, 2)>Math.Pow(najdłuższy_bok, 2))
      Console.WriteLine("ostrkątny");
    else if(Math.Pow(najkrutszy_bok_1, 2)+Math.Pow(najkrutszy_bok_2, 2)==Math.Pow(najdłuższy_bok, 2))
      Console.WriteLine("prostokątny");
         else if(Math.Pow(najkrutszy_bok_1, 2)+Math.Pow(najkrutszy_bok_2, 2)<Math.Pow(najdłuższy_bok, 2))
      Console.WriteLine("rozwartokątny");
