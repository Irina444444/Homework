Console.Write("Insert first figure for comparison: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert second figure for comparison: ");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)

{
    Console.Write("Max = ");
    Console.WriteLine(number1);
}

if (number1 < number2)

{
    Console.Write("Max = ");
    Console.WriteLine(number2);
}

if (number1 == number2)

{
    Console.WriteLine("Both figures are equal");
}