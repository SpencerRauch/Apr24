class Fruit : Food
{
    public bool Ripe { get;set; }

    public Fruit(string name, string countryOfOrigin, bool spicy, double price, bool ripe) : base(name, countryOfOrigin, spicy, price)
    {
        Ripe = ripe;
    }

    public override void PrintInfo()
    {
        base.PrintInfo(); //this is optional, only do if you want the parent class function to run
        Console.WriteLine($"Ripe: {Ripe}");
    }
}