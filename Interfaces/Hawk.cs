class Hawk : Bird, IFly
{
    public int AirSpeed { get; set; } = 120;

    public Hawk(string name) : base(name){}

    public void Fly()
    {
        Console.WriteLine($"{Name} takes to the sky at a rate of {AirSpeed} mph");
    }
}