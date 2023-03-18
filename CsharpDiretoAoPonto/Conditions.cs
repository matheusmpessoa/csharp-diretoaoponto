using System;
namespace CsharpDiretoAoPonto
{
	public class Conditions
	{
		public Conditions()
		{
			var notaDigitada = Console.ReadLine();

			var nota = int.Parse(notaDigitada);

			if (nota >= 70)
			{
				Console.Write("Aprovado");
			} else if (nota >= 40)
			{
				Console.Write("Em recuperação");
			} else
			{
				Console.Write("Reprovado");
            }



			// switch - case
			Console.Write("Seja bem-vindo a empresa X");
			Console.Write("Digite 1 - Contratação de um plano");
			Console.Write("Digite 2 - Reclamações");
			Console.Write("Digite 3 - Segunda via de boleto");
			Console.Write("Digite 4 - Sair");

			var opcao = Console.ReadLine();

			switch (opcao)
			{
				case "1":
					Console.WriteLine("Informações de novo plano");
					break;
                case "2":
                    Console.WriteLine("Fale sobre sua reclamação");
                    break;
                case "3":
                    Console.WriteLine("Segunda via de boleto enviada por e-mail.");
                    break;
                case "4":
                    Console.WriteLine("Tenha um bom dia");
                    break;
				default:
					Console.WriteLine("Opção não encontrada");
                    break;
            }
        }
	}
}

