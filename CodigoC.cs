using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("insira um numero de ponto flutuante:");
      float age = Convert.ToSingle (Console.ReadLine());
      Console.WriteLine("voce inseriu o numero: " + age);
      Console.ReadKey(true);
    }
  }
}    
