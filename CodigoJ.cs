using System;

namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Escreva o nome da rua: ");
			string rua= Console.ReadLine();
			
				Console.Write("Escreva o numero da casa: ");
				string numero= Console.ReadLine();
				
					Console.Write("Escreva o bairro: ");
					string bairro= Console.ReadLine();
			
						Console.Write("Escreva a cidade: ");
						string cidade= Console.ReadLine();
			
			
							Console.Write("Escreva o estado: ");
							string estado= Console.ReadLine();
			
			
			Console.Write("Você mora na Rua " + rua);
				Console.Write(" nº " + numero);
					Console.Write(" no Bairro " + numero);
						Console.Write(" na Cidade de " + bairro);
							Console.Write(" no Estado " + estado);
			
			
			Console.ReadKey(true);
		}
	}
}
