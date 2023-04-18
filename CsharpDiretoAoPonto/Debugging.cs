﻿using System;
namespace CsharpDiretoAoPonto
{
	public class Debugging
	{
		public Debugging()
		{
            #region Debugging
            var numerosString = Console.ReadLine();
            var numeros = numerosString.Split(' ');

            foreach (var numero in numeros)
            {
                var numeroInt = int.Parse(numero);
                var aoQuadrado = Math.Pow(numeroInt, 2);

                Console.WriteLine($"{numeroInt} = {aoQuadrado}");
            }
            #endregion
        }
    }
}

