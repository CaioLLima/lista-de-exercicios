namespace ListaDeExercicios.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de uma caixa retangular
            //VOLUME_DA_CAIXA Comprimento * Largura * Altura

            #region input de dados
            Console.Write("Digite o comprimento da caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a largura da caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a altura da caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processamento
            decimal volume_caixa = comprimento * largura * altura;
            #endregion

            #region output dos dados
            Console.Write($"O volume da caixa é de: {volume_caixa}");
            #endregion

            Console.ReadLine();
        }
    }
}
