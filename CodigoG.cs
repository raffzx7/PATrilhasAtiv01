using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("insira sua idade:");
      int age = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("insira seu nome:");
      string nome = Convert.ToString(Console.ReadLine());
      Console.WriteLine("idade: " + age);
      Console.WriteLine("nome: " + nome);
      
      Console.ReadKey(true);
    }
  }
}   
