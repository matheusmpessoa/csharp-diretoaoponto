using System;
namespace CsharpDiretoAoPonto
{
	public class WorkingWithStrings
	{
		public WorkingWithStrings()
		{
			var paragrafo = "      C# é uma linguagem moderna e versátil. " +
				"Com C# consigo desenvolver para Web, Desktop, Jogos, " +
				"Mobile, entre outros. ";

			// Length
			var tamanho = paragrafo.Length;

            // Empty
            var vazio = string.Empty;

			// ToLower, ToUpper
			var paragrafoMinusculo = paragrafo.ToLower();
			var paragrafoMaiusculo = paragrafo.ToUpper();

			// Split
			var frases = paragrafo.Split('.');

			// Trim, TrimEnd, TrimStart
			var paragrafoTrim = paragrafo.Trim();
			var paragrafoTrimEnd = paragrafo.TrimEnd();
			var paragrafoTrimStart = paragrafo.TrimStart();

			// IsNullOrWhiteSpace
			var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(paragrafo); // null ou vazio

			// Replace
			var paragrafoCsharp = paragrafo.Replace("C#", "C-sharp");

            // ----------

            #region busca
            var outroParagrafo = "C# é uma linguagem moderna e versátil. " +
                "Com C# consigo desenvolver para Web, Desktop, Jogos, " +
                "Mobile, entre outros. ";

			// IndexOf
			var indexOf = outroParagrafo.IndexOf("C#");

			// LastIndexOf
			var lastIndexOf = outroParagrafo.LastIndexOf("C#");

            // StartsWith
            var startsWith = outroParagrafo.StartsWith("C#");

            // Substring
            var indexOfMobile = outroParagrafo.IndexOf("Mobile");
            var substringMobile = outroParagrafo.Substring(indexOfMobile, 6);

			// Contains
			var containJogos = outroParagrafo.Contains("jogos", StringComparison.OrdinalIgnoreCase);
				// nao se importa com maiusculo ou minusculo
			var containJogosExact = outroParagrafo.Contains("Jogos");
			// palavra exata
			var containsRuim = outroParagrafo.Contains("ruim");
				// vai retornar falso

            #endregion busca

            Console.ReadKey();
        }
    }
}

