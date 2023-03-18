class Operators
{
    static void Main(string[] args)
    {
        #region Operadores Aritméticos

        // Unários ++, --, + e -
        int numeroOperador = 4;
        Console.Write(numeroOperador++); //4
        Console.Write(numeroOperador--); //5

        Console.Write(++numeroOperador); //5
        Console.Write(--numeroOperador); //4

        Console.Write(numeroOperador);
        Console.Write(-numeroOperador);
        Console.Write(-(-numeroOperador));
        #endregion


        #region Operadores Aritméticos
        Console.Write(4 > 5);
        Console.Write(4 > 5);
        Console.Write(6 >= 5);

        Console.Write(5 < 4);
        Console.Write(5 <= 5);
        Console.Write(5 < 6);
        #endregion


        #region Operadores de igualdade
        Console.Write(5 == 5);
        Console.Write(5 == 4);

        Console.Write(5 != 5);
        Console.Write(4 != 5);
        #endregion


        #region Operadores lógicos AND && e OR ||
        var minhaNota = 4;
        var ultimoAno = true;

        if (minhaNota >= 7 && ultimoAno)
        {
            Console.Write("Aprovado! Você finalizou o curso");
        }

        if (minhaNota >= 7 || ultimoAno)
        {
            Console.Write("Aprovado!");
        }


        Console.Write(true || false);
        Console.Write(false || true);
        Console.Write(true || true);
        Console.Write(false || false);

        Console.Write(true && false);
        Console.Write(false && false);
        Console.Write(true && true);
        Console.Write(false && false);
        #endregion

        Console.Read();
    }
}
