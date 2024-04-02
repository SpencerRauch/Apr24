class Food
{
    private string Name;
    private string CountryOfOrigin;
    public bool Spicy { get;set; } //this is how we will set up a lot of our models
    private double _price;
    public double Price {get{return _price;} set{ if(value >= 0.01) _price = value;}}

    public Food(string name, string countryOfOrigin, bool spicy, double price)
    {
        Name = name;
        CountryOfOrigin = countryOfOrigin;
        Spicy = spicy;
        _price = price;
    }

    public Food(string name, string countryOfOrigin, bool spicy)
    {
        Name = name;
        CountryOfOrigin = countryOfOrigin;
        Spicy = spicy;
        _price = 0.00;
    }

    public Food(string name, string countryOfOrigin, double price)
    {
        Name = name;
        CountryOfOrigin = countryOfOrigin;
        Spicy = false;
        _price = price;
    }

    public Food()
    {
        Name = "Generic Food";
        CountryOfOrigin = "Parts Unknown";
        Spicy = false;
        _price = 0.00;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine($"CoO: {CountryOfOrigin}");
        Console.WriteLine($"Spicy: {Spicy}");
        Console.WriteLine($"Price: {Price}");
    }

    public virtual void PrintInfo(int times)
    {
        for (int i = 0; i < times; i++)
        {
            PrintInfo();
        }
    }
}