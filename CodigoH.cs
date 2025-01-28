using System;

class Program
{
    static void Main()
    {
        Console.Write("insira o preço do produto: R$");
        	double preco = Convert.ToDouble(Console.ReadLine());
        Console.Write("insira o desconto: ");
        	  double desconto = Convert.ToDouble(Console.ReadLine());
        	    double valorDesconto = preco * (desconto / 100);
        	      double valorFinal = preco - valorDesconto;
        	Console.Write("preço com desconto: R$" + valorFinal);
        	  Console.ReadKey(true);
    }
}
