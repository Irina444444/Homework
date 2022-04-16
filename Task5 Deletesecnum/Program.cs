int randNumber = new Random().Next(100,1000);
int numA = (randNumber - (randNumber % 100)) / 100;
int numB = randNumber % 10;
Console.WriteLine($"{numA}{numB}");