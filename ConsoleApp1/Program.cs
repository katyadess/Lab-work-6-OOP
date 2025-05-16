using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Random random = new Random();
List<int> N = new List<int>();
for (int i = 0; i < 10; i++)
{
    N.Add(random.Next(10, 100));
    Console.Write("{0} ", N[i]);

}

