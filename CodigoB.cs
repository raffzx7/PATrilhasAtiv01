using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("insira um numero com decimal:");
      double age = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("voce inseriu o numero: " + age);
      Console.ReadKey(true);
    }
  }
}    
