namespace ListaDeExercicios.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
            #region input de dados
            Console.Write("Digite a temperatura em Celsius: ");
            double tempCelsius = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double tempKelvin = tempCelsius * 1.8 + 32;
            #endregion

            #region output dos dados
            Console.Write($"A temperatura em Fahrenheint é de: {tempKelvin}");
            #endregion

            Console.ReadLine();
        }
    }
}
