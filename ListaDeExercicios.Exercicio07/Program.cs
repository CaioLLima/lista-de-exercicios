namespace ListaDeExercicios.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
            #region input de dados
            Console.Write("Informe o peso da primeira prova: ");
            double pesoProva1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota da primeira prova: ");
            double notaProva1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o peso da segunda prova: ");
            double pesoProva2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota da segunda prova: ");
            double notaProva2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o peso da segunda prova: ");
            double pesoProva3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota da segunda prova: ");
            double notaProva3 = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double mediaPonderada = (pesoProva1 * notaProva1) + (pesoProva2 * notaProva2) + (pesoProva3 * notaProva3);
            double divisao = pesoProva1 + notaProva2 + notaProva3;
            #endregion

            #region output dos dados
            Console.Write($"A media ponderada das duas provas é de : {mediaPonderada / divisao}");
            #endregion
        }
    }
}
