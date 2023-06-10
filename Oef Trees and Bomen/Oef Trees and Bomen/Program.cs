// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, future champ!");


DartChampions root = new DartChampions(2017, "Michael van Gerwen", 21.5f, "Nederland", 3);
root.Add(new DartChampions(2018, "Rob Cross", 22, "Engeland", 1, root));
root.Add(new DartChampions(2019, "Michael van Gerwen", 21.5f, "Nederland", 3, root)) ;
root.Add(new DartChampions(2020, "Peter Wright", 24, "Engeland", 2, root));


DartChampions c1 = root.getyear(2017);
{
    if (c1 != null)
    {
        Console.WriteLine("Hello person");
        Console.WriteLine();
        Console.WriteLine("Year: " + c1.GetYear() );
        Console.WriteLine("Champion name: " + c1.GetName());
        Console.WriteLine("Dart weight: " + c1.GetDartWeight());
        Console.WriteLine("Country: " + c1.GetCountry());
        Console.WriteLine("Wins: " + c1.GetWins());
    }
}
Console.WriteLine();
DartChampions c2 = root.getyear(2018);
{
    if (c2 != null)
    {
        Console.WriteLine("Hello person");
        Console.WriteLine();
        Console.WriteLine("Year: " + c2.GetYear());
        Console.WriteLine("Champion name: " + c2.GetName());
        Console.WriteLine("Dart weight: " + c2.GetDartWeight());
        Console.WriteLine("Country: " + c2.GetCountry());
        Console.WriteLine("Wins: " + c2.GetWins());
    }
}
Console.WriteLine();
DartChampions c3 = root.getyear(2019);
{
    if (c3 != null)
    {
        Console.WriteLine("Hello person");
        Console.WriteLine();
        Console.WriteLine("Year: " + c3.GetYear());
        Console.WriteLine("Champion name: " + c3.GetName());
        Console.WriteLine("Dart weight: " + c3.GetDartWeight());
        Console.WriteLine("Country: " + c3.GetCountry());
        Console.WriteLine("Wins: " + c3.GetWins());
    }
}
Console.WriteLine();
DartChampions c4 = root.getyear(2020);
{
    if (c4 != null)
    {
        Console.WriteLine("Hello person");
        Console.WriteLine();
        Console.WriteLine("Year: " + c4.GetYear());
        Console.WriteLine("Champion name: " + c4.GetName());
        Console.WriteLine("Dart weight: " + c4.GetDartWeight());
        Console.WriteLine("Country: " + c4.GetCountry());
        Console.WriteLine("Wins: " + c4.GetWins());
    }
}
public class DartChampions
  {
    public int Year { get; private set; }
    public string Name { get; private set; }
    public float DartWeight { get; private set; }
    
    public string Country { get; private set; }
    public int Wins { get; private set; }

    List<DartChampions> list { get; } = new List<DartChampions>();
    DartChampions Parent = null;

    public DartChampions( int Year,string Name, float DartWeight, string Country, int Wins, DartChampions Parent = null)
    {
        this.Year = Year;
        this.Name = Name;
        this.DartWeight = DartWeight;
       
        this.Country = Country;
        this.Wins = Wins;
        Parent = Parent;
        
    }
    
    public void Add(DartChampions Year)
    {
        list.Add(Year);
    }
    public DartChampions GetParent()
    {
        return Parent;
    }
    public float GetDartWeight()
    {
        float weight = DartWeight;
        return weight;

    }
    public string GetName()
    {
        string name = Name;
        return name;
    }
   
    public string GetCountry()
    {
        string name = Country;
        return name;
    }
    public DartChampions getyear(int year)
    {
        if (Year.Equals(year))
        {
            return this;
        }
        foreach (var c in list)
        {
            var result = c.getyear(year);
            if (result != null)
            {
                return result;
            }
        }

        return null;
    }
    public int GetYear()
    {
        int year = Year;
            return year;
    }
    public int GetWins()
    {
        int wins = Wins;
        return Wins;

    }
    DartChampions GetRoot()
    {
        if (Parent == null) return this;
        return Parent.GetRoot();
    }

  }