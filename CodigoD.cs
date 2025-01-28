using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("escreva sim ou não:");
      string resposta = Console.ReadLine().ToLower(); 

      bool valor = false;
       
      if   (resposta == "sim")
      		 {
      	valor = true;
        }
        Console.WriteLine("Você escolheu: " + valor); 
    	Console.ReadKey(true);
    }
  }
}
