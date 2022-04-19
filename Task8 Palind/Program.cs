//five-digit number to check if it is palindrom figure or not
Console.WriteLine("Insert 5-digit number: ");

int num = Convert.ToInt32(Console.ReadLine());

string str = Convert.ToString(num);

string str0 = Convert.ToString(str [0]);
int num0 = Convert.ToInt32(str0);
string str4 = Convert.ToString(str [4]);
int num4 = Convert.ToInt32(str4);
string str1 = Convert.ToString(str [1]);
int num1 = Convert.ToInt32(str1);
string str3 = Convert.ToString(str [3]);
int num3 = Convert.ToInt32(str3);

if (str.Length == 5 & (num0 == num4 & num1 == num3))
{
    Console.WriteLine("Palindrom number");
}
else
{
   if (str.Length !=5)
{
    Console.WriteLine("Error: 5-digit number need");
}
else 
    Console.WriteLine("No palindrom number");
}


