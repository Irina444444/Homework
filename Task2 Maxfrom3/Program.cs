Console.WriteLine("Insert three figure for comparison: ");

int number1 = Convert.ToInt32(Console.ReadLine()); 
int number2 = Convert.ToInt32(Console.ReadLine()); 
int number3 = Convert.ToInt32(Console.ReadLine());

if ((number1 > number2) && (number1 > number3))

{   
    Console.WriteLine("Max from three: ");
    Console.WriteLine(number1);
}

else

if (number2 > number3) 

{
     Console.WriteLine("Max from three: ");
    Console.WriteLine(number2);
}
else

{
     Console.WriteLine("Max from three: ");
    Console.WriteLine(number3);
}
