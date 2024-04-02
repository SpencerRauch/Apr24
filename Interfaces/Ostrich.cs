class Ostrich : Bird, IRun
{
    public int LandSpeed { get; set; } = 43;

    public Ostrich(string name) :base(name)
    {
        Name = name;
    }

    public void Run()
    {
        Console.WriteLine($"{Name} runs off at {LandSpeed} mph");
    }
}