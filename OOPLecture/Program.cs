// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Food Pasta = new("pasta","Italy",false,10.00);
// Pasta.PrintInfo();
// Console.WriteLine(Pasta.Price);
Pasta.Price = 1000;
Pasta.Price = -9;

// Pasta.PrintInfo();

Fruit Kiwi = new("Kiwi","New Zealand",false,0.50,true);
// Kiwi.PrintInfo();

Food emptyFood = new();
// emptyFood.PrintInfo();

Food testFood = new();

Pasta.PrintInfo(3);

Kiwi.PrintInfo(2);