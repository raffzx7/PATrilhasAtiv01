using System;

namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("insira uma palavra: ");
			string letras = Console.ReadLine();		 	
			
			Console.WriteLine("O cumprimento da palavra é: " +letras.Length);
			Console.ReadKey(true);
		}
	}

}
