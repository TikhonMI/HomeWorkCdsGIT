using DistanceInch;

Distance a = new Distance(20, 11);
Distance b = new Distance(20, 8);
Distance c = a+b;
Distance d = a-b;

Console.WriteLine(c.ToString());
Console.WriteLine(d.ToString());
Console.WriteLine(a != b);
Console.WriteLine(a == b);
