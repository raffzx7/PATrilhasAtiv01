using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("insira um caractere:");
        char age = Convert.ToChar (Console.ReadLine());
          Console.WriteLine("voce inseriu o caractere: " + age);
            Console.ReadKey(true);
    }
  }
}    
