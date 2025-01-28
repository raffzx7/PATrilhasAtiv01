using System;

namespace MyApplication
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("insira um numero decimal:");
        decimal numero = Convert.ToDecimal (Console.ReadLine());
          Console.WriteLine("voce inseriu o numero: " + numero);
            Console.ReadKey(true);
    }
  }
}  
