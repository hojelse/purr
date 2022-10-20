using System;
using System.Collections.Generic;
using System.Linq;

class compass
{
  static void Main(string[] args) {
    int N = int.Parse(Console.ReadLine());

    HashSet<string> set = new HashSet<string>();

    for (int i = 0; i < N; i++)
    {
      List<string> tokens = Console.ReadLine().Split(" ").ToList();
      if (tokens.Count() == 2)
      {
        set.Add(tokens[1]);
      } else {
        var right = tokens.Last();

        for (int j = 0; j < tokens.Count()-2; j++)
        {
          // Console.WriteLine($"debug: {tokens[j]}");
          if (!set.Contains(tokens[j]))
          {
            Console.WriteLine(i+1);
            return;
          }
        }
        set.Add(right);
      }
    }

    Console.WriteLine("correct");
  }
}