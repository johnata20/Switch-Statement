int order;

Console.WriteLine("These are all the available beverages : ");
Console.WriteLine("1) Coke");
Console.WriteLine("2) Sprite");
Console.WriteLine("3) Royal Orange");
Console.WriteLine("4) Mountain Dew");
Console.WriteLine("5) Mineral Water");

Console.WriteLine();
Console.Write("Enter the number of your selection : ");
order = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("You have selected ");

switch (order)
{
    case 1:
        Console.WriteLine("Coke.");
        break;
    case 2:
        Console.WriteLine("Sprite.");
        break;
    case 3:
        Console.WriteLine("Royal Orange.");
        break;
    case 4:
        Console.WriteLine("Mountain Dew.");
        break;
    case 5:
        Console.WriteLine("Mineral Water.");
        break;
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadLine();
