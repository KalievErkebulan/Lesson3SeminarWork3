Console.Clear();
double FindingDistance(double xFirst, double yFirst, double xSecond, double ySecond)
{
    double distance = Math.Sqrt(Math.Pow(xFirst-xSecond,2) + Math.Pow(yFirst-ySecond,2));  
    return distance;
}
Console.WriteLine($"Введите координаты xFirst: ");
int xFirst = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите координаты yFirst: ");
int yFirst = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите координаты xSecond: ");
int xSecond = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите координаты ySecond: ");
int ySecond = int.Parse(Console.ReadLine()!);
FindingDistance( xFirst,  yFirst,  xSecond,  ySecond);
double d = FindingDistance( xFirst,  yFirst,  xSecond,  ySecond);
Console.WriteLine();
Console.WriteLine($"{d:f3}");


// Console.Clear();
// int x = 2;
// int y = 3;
// int xTWo = 4;
// int yTwo = 7;
// double v = Math.Abs(xTWo-x);
// double b = Math.Abs(yTwo-y);
// double z = Math.Sqrt( b + y );

// Console.WriteLine($"{z}");