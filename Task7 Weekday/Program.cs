int num = new Random().Next(1,8);
Console.WriteLine($"{num}");
if (num == 1 | num ==  2 | num == 3 | num == 4 | num == 5)
{
    Console.WriteLine("Weekgday");
}
else
{
    Console.WriteLine("Weekend");
}