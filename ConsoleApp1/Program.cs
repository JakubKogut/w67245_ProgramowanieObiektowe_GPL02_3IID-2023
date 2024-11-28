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
//using System;

//class Program
//{
//  static void Main()
//{
//  Console.WriteLine("Podaj liczbe n:");
//int n = int.Parse(Console.ReadLine());

//Console.WriteLine("Parzyste liczby od 1 do {0}", n);

//        for (int i = 1; i <= n; i++)
//      {
//        if (i % 2 == 0)
//      {
//        Console.WriteLine(i);
//  }
// }
// }
//}

//zadanie3

//while (true)
//{
//  Console.WriteLine("Wybierz opcje");
//Console.WriteLine("1. Parzyste");
// Console.WriteLine("2. Ile licz parzystych");
//Console.WriteLine("3. Silnia");
//Console.WriteLine("0. Wyjscie");


//}

//zadanie 1 lab 2-3
public class Person
{
    private string name;
    private string surname;
    private int age;
    private string pesel;

    public Person(string name, string surname, int wiek, string pesel)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.pesel = pesel;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0) age = 0;
            else age = value;

        }

    }
    public string Pesel
    {
        get { return pesel; }
    }

    public void IntroduceYourself()
    {
        Console.WriteLine($"My name is {name} {surname} and my age is {age}.");
    }
}
public class Program
{
    public static void Main()
    {
        Person person = new Person("Jan", "Kowalski", 25 , "123456789");
        person.IntroduceYourself();
    }
}


public class zadanie2
{
    public double number;

    public void Add(double value)
    {
        this.number += value;
    }
    public void WriteValue()
        { Console.WriteLine(number); }
}

public class zadanie3
{
    public int[] Numbers { get; set; } = new int[] { 10, 20, 30 };

    public int Sum() { return Numbers.Sum(); }


    public double SumDiv3() { return Numbers.Where(x => x % 3 == 0).Sum(); }
    public int Count() { return Numbers.Count(); }

    public void Display(int low, int high);

}


public string GetGender()
{
    var g = int.Parse(Pesel[9].ToString())

    return g % 2 == 0 ? "Woman" : "Man"


}

public int GetAge()

{
    var year = int.Parse(Pesel.substring(0,2))
    var month = int.Parse(Pesel.substring(2, 2))

    if (month > 80)
    {
        year += 1800;
    }
    else if (month > 20)
    {
        year += 2000;
    }
    else
    {
        year += 1900;

    }
    return DateTime.Today.Year - year

}



{
    internal class Student : Person2
{
    public string 
}
}