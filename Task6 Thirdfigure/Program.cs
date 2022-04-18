int num = new Random().Next();
Console.WriteLine ($"{num}");
string str = Convert.ToString(num);
if (str.Length <= 2)

{
   Console.WriteLine("There is no third figure");
}
else
{
    Console.WriteLine(str [2]);
}