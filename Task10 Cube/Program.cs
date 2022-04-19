Console.Clear();
Console.WriteLine("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; (i <= number) & (i > 0); i++)

{
                Console.WriteLine(Math.Pow(i, 3));
}
for (int i = number; i < 0; i++)

{
       Console.Write(Math.Pow(i, 3));
}
if (number == 0)
{
    Console.WriteLine("0");
}