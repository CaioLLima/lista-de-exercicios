using System;

namespace ListaDeExercicios.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

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
