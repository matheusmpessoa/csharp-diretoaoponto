using System;
namespace CsharpDiretoAoPonto
{
	public class Exception
	{
		public Exception()
		{
            #region Tratando exceções
            var seteString = "sete";
            string valorNull = null;
            var longValue = long.MaxValue.ToString();

            try
            {
                var formatException = int.Parse(seteString);
                var argumentoNullException = int.Parse(valorNull);
                var overflowException = int.Parse(longValue);
            } catch(FormatException exception)
            {
                Console.WriteLine($"Format Exception: {exception.Message}");
            } catch (ArgumentNullException exception)
            {
                Console.WriteLine($"Argument Null Exception: {exception.Message}");
            } catch (OverflowException exception)
            {
                Console.WriteLine($"Overflow Exception: {exception.Message}");
            } finally
            {
                Console.WriteLine($"Este código é executado sempre");
            }
            #endregion

            Console.ReadKey();
        }
    }
}

