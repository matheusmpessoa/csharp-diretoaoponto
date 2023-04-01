using System;
namespace CsharpDiretoAoPonto
{
	public class Arrays
	{
		public Arrays()
		{

            #region Arrays
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbersCopy = new int[10];

            for (var i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[i];
            }

            var numbersString = "0 1 2 3 4 5 6 7 8 9";
            var numbersArray = numbersString.Split(' ');
            var numbersConvertedFromString = Array.ConvertAll(numbersArray, Convert.ToInt32);
            #endregion Arrays

            #region Listas
            var list = new List<int> { 0, 1, 2, 3, 4};
            var listFromArray = new List<int>(numbers);

            list.Add(5); // valor unitário
            list.AddRange(new List<int> { 6, 7 }); // valor adicionado de uma lista
            list.AddRange(new int[] { 6, 7 }); // tipo de colecoes

            var count = list.Count;
            var contains14 = list.Contains(14); 
            var contains2 = list.Contains(2); // false

            Console.WriteLine("Lista reversa");
            list.Reverse(); // métod retorna void, nao é necessario/possivel atribuir
            list.ForEach(l => Console.WriteLine(l));

            Console.WriteLine("Lista ordenada");
            list.Sort();
            list.ForEach(l => Console.WriteLine(l));

            list.Remove(4);
            list.RemoveAll(l => l > 5); // expressao lambda que tem a condicao de remover maiores que 5
            #endregion

            Console.ReadKey();
        }
    }
}

