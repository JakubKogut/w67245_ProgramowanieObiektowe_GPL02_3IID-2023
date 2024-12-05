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
//public class Person
//{
//  private string name;
//private string surname;
//private int age;
//private string pesel;

//public Person(string name, string surname, int wiek, string pesel)
//{
//  this.name = name;
//this.surname = surname;
//this.age = age;
//this.pesel = pesel;
// }
//public string Name
//{
//  get { return name; }
//set { name = value; }
// }

//    public string Surname
//  {
//     get { return surname; }
//   set { surname = value; }
// }
//public int Age
//{
//  get { return age; }
//set
//{
//  if (value < 0) age = 0;
//else age = value;

/*}

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
*/
//lab 5 zad 1


public abstract class Shape
{

    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }


    public Circle(double radius)
    {
        Radius = radius;
    }


    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}


public class Square : Shape
{
    public double Side { get; set; }


    public Square(double side)
    {
        Side = side;
    }


    public override double CalculateArea()
    {
        return Side * Side;
    }
}



// lab5 zad2
public interface IVehicle
{

    void Start();


    void Stop();


    int MaxSpeed { get; }
}


public class Car : IVehicle
{
    public int MaxSpeed { get; private set; }


    public string Model { get; set; }


    public Car(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
    }


    public void Start()
    {
        Console.WriteLine($"{Model} car is starting.");
    }


    public void Stop()
    {
        Console.WriteLine($"{Model} car is stopping.");
    }


    public void Honk()
    {
        Console.WriteLine("Car is honking!");
    }
}


public class Bike : IVehicle
{
    public int MaxSpeed { get; private set; }


    public bool HasBell { get; set; }


    public Bike(int maxSpeed, bool hasBell)
    {
        MaxSpeed = maxSpeed;
        HasBell = hasBell;
    }


    public void Start()
    {
        Console.WriteLine("Bike is starting.");
    }


    public void Stop()
    {
        Console.WriteLine("Bike is stopping.");
    }


    public void Ring()
    {
        if (HasBell)
        {
            Console.WriteLine("Bike bell is ringing!");
        }
        else
        {
            Console.WriteLine("This bike doesn't have a bell.");
        }
    }
}

//lab5 zad3


public interface IEntity<T>
{
    T Id { get; set; }
}

public interface ICreationDate
{
    DateTime CreatedAt { get; set; }
}

public class Book : IEntity<int>, ICreationDate
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearOfPublication { get; set; }
    public DateTime CreatedAt { get; set; }


    public Book(int id, string title, string author, int yearOfPublication, DateTime createdAt)
    {
        Id = id;
        Title = title;
        Author = author;
        YearOfPublication = yearOfPublication;
        CreatedAt = createdAt;
    }
}


public class Person : IEntity<int>, ICreationDate
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public List<Book> BorrowedBooks { get; set; }
    public DateTime CreatedAt { get; set; }


    public Person(int id, string firstName, string lastName, int age, DateTime createdAt)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        BorrowedBooks = new List<Book>();
        CreatedAt = createdAt;
    }
}


public interface IBaseRepository<T, TEntity> where T : IEntity<T>
{
    void Create(TEntity entity);
    void Update(TEntity entity);
    TEntity Get(int id);
    IEnumerable<TEntity> GetAll();
    void Delete(int id);
}


public class BookRepository : IBookRepository
{
    private List<Book> _books = new List<Book>();

    public void Create(Book entity)
    {
        _books.Add(entity);
    }

    public void Update(Book entity)
    {
        var existingBook = _books.FirstOrDefault(b => b.Id == entity.Id);
        if (existingBook != null)
        {
            existingBook.Title = entity.Title;
            existingBook.Author = entity.Author;
            existingBook.YearOfPublication = entity.YearOfPublication;
            existingBook.CreatedAt = entity.CreatedAt;
        }
    }

    public Book Get(int id)
    {
        return _books.FirstOrDefault(b => b.Id == id);
    }

    public IEnumerable<Book> GetAll()
    {
        return _books;
    }

    public void Delete(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        if (book != null)
        {
            _books.Remove(book);
        }
    }
}

public class PersonRepository : IPersonRepository
{
    private List<Person> _people = new List<Person>();

    public void Create(Person entity)
    {
        _people.Add(entity);
    }

    public void Update(Person entity)
    {
        var existingPerson = _people.FirstOrDefault(p => p.Id == entity.Id);
        if (existingPerson != null)
        {
            existingPerson.FirstName = entity.FirstName;
            existingPerson.LastName = entity.LastName;
            existingPerson.Age = entity.Age;
            existingPerson.CreatedAt = entity.CreatedAt;
        }
    }

    public Person Get(int id)
    {
        return _people.FirstOrDefault(p => p.Id == id);
    }

    public IEnumerable<Person> GetAll()
    {
        return _people;
    }

    public void Delete(int id)
    {
        var person = _people.FirstOrDefault(p => p.Id == id);
        if (person != null)
        {
            _people.Remove(person);
        }
    }
}

