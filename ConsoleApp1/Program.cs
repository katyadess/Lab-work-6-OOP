using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Random random = new Random();
List<int> N = new List<int>();
for (int i = 0; i < 10; i++)
{
    N.Add(random.Next(10, 100));
    Console.Write("{0} ", N[i]);
}


//Task 1

int minIndex = 0;
for (int i = 0; i < N.Count; i++)
{
    if (N[i] < N[minIndex])
    {
        minIndex = i;
    }
}


N.RemoveAt(minIndex);
Console.WriteLine("\nКолекція після видалення першого мінімального значення:");
Console.WriteLine(string.Join(" ", N));




//Task 2

int X = 5;
for (int i = 0; i < N.Count; i++)
{
    if (N[i] % X == 0)
    {
        N.Insert(i, X);
        i++;
    }
}


Console.WriteLine($"\nКолекція після вставки числа {X} перед кожним числом, кратним {X}:");
Console.WriteLine(string.Join(" ", N));




//Task 3

List<int> endsWithZero = new List<int>();
List<int> others = new List<int>();

foreach (int number in N)
{
    if (number % 10 == 0)
    {
        endsWithZero.Add(number);
    }
    else
    {
        others.Add(number);
    }
}

Console.WriteLine("\nЧисла, які закінчуються на 0:");
Console.WriteLine(string.Join(" ", endsWithZero));

Console.WriteLine("\nІнші числа:");
Console.WriteLine(string.Join(" ", others));

