using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("insira um numero:");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("voce inseriu o numero: " + age);
      Console.ReadKey(true);
    }
  }
}    
