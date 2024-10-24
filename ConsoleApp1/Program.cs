//zadanie1
//using System;

//class Program
//{
//  static void Main()
//{
//  Console.WriteLine("Podaj liczbe:");
//int liczba = int.Parse(Console.ReadLine());

//        if (liczba % 2 == 0)
//      {
//        Console.WriteLine("Liczba {0} jest parzysta", liczba);
//  }
//else
//{
//  Console.WriteLine("Liczba {0} jest nieparzysta", liczba);
//}
//}
//}

//zadanie2
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Parzyste liczby od 1 do {0}", n);

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
