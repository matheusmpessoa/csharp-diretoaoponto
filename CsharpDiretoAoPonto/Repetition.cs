using System;
namespace CsharpDiretoAoPonto
{
	public class Repetition
	{
		public Repetition()
		{
			Console.WriteLine("Digite uma sequência de números separados por um espaço");
			// 0 1 2 3 4 5 6 7 8 9

			var numerosTexto = Console.ReadLine();
			var numeros = numerosTexto.Split(' ');

			Console.WriteLine("Utilizando for: ");
			for (int i = 0; i > numerosTexto.Length; i++)
			{
				Console.WriteLine(numeros[i]);
				// 0 1 2 3
			}


            Console.WriteLine("Utilizando while: ");
			var contador = 0;
			while (contador < numeros.Length)
			{
				Console.WriteLine(numeros[contador]);
				contador++;
			}


            Console.WriteLine("Utilizando foreach: ");
			foreach(var numero in numeros)
			{
				Console.WriteLine(numero);
			}

            Console.ReadKey();
		}
	}
}

