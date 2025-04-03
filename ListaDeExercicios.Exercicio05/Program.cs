namespace ListaDeExercicios.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
            //vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.

            #region input de dados
            Console.Write("Informe o salário base: ");
            double salBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o total de vendas: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o percentual da comissão: ");
            double comissao = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double salTotal = salBase + (totalVendas * (comissao/100));
            #endregion

            #region output dos dados
            Console.Write($"O salário total do vendedor é de: {salTotal} reais. A comissão foi de {(totalVendas * (comissao / 100))} reais.");
            #endregion

            Console.ReadLine();
        }
    }
}
