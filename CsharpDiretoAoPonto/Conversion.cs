class Conversion
{
    static void Main(string[] args)
    {
        #region Conversões

        int notaAluno = 10;

        // conversao implicita
        double notaAlunoDouble = notaAluno;


        // conversao explicita
        int numeroDoubleComoInt = (int) notaAlunoDouble;


        // conversao utilizando Convert
        string notaString = "10";
        int notaConvert = Convert.ToInt32(notaString);


        // conversao utilizando parse
        int notaParse = int.Parse(notaString);

        if(int.TryParse(notaString, out int notaTryParse))
        {

        } else {
            Console.Write("Número inválido");
        }

        #endregion

        Console.Read();
    }
}
