Console.WriteLine("Hello, World!");

partial class Program
{
    static void Main(string[] args)
    {
        #region Tipos de Dados

        int numeroInt = 50;
        int maiorNumeroInt = int.MaxValue;
        int menorNumeroInt = int.MinValue;

        long numeroLong = 12131412414;
        long maiorNumeroLong = long.MaxValue;
        long menorNumeroLong = long.MinValue;

        decimal numeroDecimal = 10.52m;

        double numeroDouble = 12.3;
        double menorNumeroDouble = double.MinValue;

        bool verdadeiro = true;
        bool falso = false;

        var numero = 10;

        string nome = "Matheus Pessoa";
        char letra = 'M';

        DateTime entradaEmpresa = new DateTime(2023, 1, 1);
        TimeSpan quantoTempoEmpresa = DateTime.Now - entradaEmpresa;

        #endregion

        Console.Read();
    }
}
