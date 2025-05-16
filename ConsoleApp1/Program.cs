using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Random random = new Random();
List<int> N = new List<int>();
for (int i = 0; i < 10; i++)
{
    N.Add(random.Next(10, 100));
    Console.Write("{0} ", N[i]);
}

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

