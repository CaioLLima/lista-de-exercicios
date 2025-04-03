namespace ListaDeExercicios.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de um cilíndro
            //VOLUME_DA_CILINDRO V = pi * raio² * a

            #region input de dados

            Console.Write("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double resultado = Math.PI * Math.Pow(raio, 2) * altura;
            #endregion

            #region output dos dados
            Console.Write($"O tamanho da caida é de: {resultado} ");
            #endregion

            Console.ReadLine();
        }
    }
}
