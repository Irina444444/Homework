Console.WriteLine("Insert figure");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Even figures:");

for (int i = 1; (i <= number) && (i > 0); i++)

if (i % 2 == 0)
{
    Console.WriteLine( + i);
}

for (int i = number; i < 0; i++)

if (i % 2 == 0)

{
    Console.WriteLine( + i);
}