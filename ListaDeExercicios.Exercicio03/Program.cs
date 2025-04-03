namespace ListaDeExercicios.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O programa deve solicitar ao usuário:
                ● A quilometragem inicial do veículo no início da viagem.
                ● A quilometragem final ao término da viagem.
                ● A quantidade de combustível consumida durante a viagem (em litros).*/

            #region input de dados
            Console.Write("Digite a quilometragem inical do veículo: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem final do veículo: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de combustível consumida na viagem em litros: ");
            double combustivelLitros = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double resultado = (kmFinal - kmInicial) / combustivelLitros;
            #endregion

            #region output dos dados
            Console.Write($"O consumo do combustível é de: {resultado}");
            #endregion

            Console.ReadLine();
        }
    }
}
