namespace ListaDeExercicios.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
            #region input de dados
            Console.Write("Informe o peso da primeira prova: ");
            decimal pesoProva1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a nota da primeira prova: ");
            decimal notaProva1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o peso da segunda prova: ");
            decimal pesoProva2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a nota da segunda prova: ");
            decimal notaProva2 = Convert.ToDecimal(Console.ReadLine());

            #endregion

            #region processamento
            decimal mediaPonderada = ((pesoProva1 * notaProva1) + (pesoProva2 * notaProva2)) / (pesoProva1 + pesoProva2);

            #endregion

            #region output dos dados
            Console.Write($"A media ponderada das duas provas é de : {mediaPonderada}");
            #endregion

            Console.ReadLine();
        }
    }
}
