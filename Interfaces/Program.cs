// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Bird birb = new Bird(); // cannot instantiate abstract classes
Hawk RedTail = new("RedTail");
Ostrich Ozzy = new("Ozzy");
Duck Daffy = new("Daffy");

List<Bird> AllBirds = [RedTail,Ozzy,Daffy];

foreach (Bird bird in AllBirds)
{
    if (bird is IFly f )
    {
        f.Fly();
    }
    if (bird is IRun r)
    {
        r.Run();
    }
    if (bird is ISwim s)
    {
        s.Swim();
    }
}