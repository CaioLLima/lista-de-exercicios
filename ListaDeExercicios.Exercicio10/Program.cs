namespace ListaDeExercicios.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
            a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) 2. Elabore um algoritmo que leia o
            peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
            ● IMC em adultos Condição
            ● Abaixo de 18,5
            ● Abaixo do peso
            ● Entre 18,5 e 25 Peso normal
            ● Entre 25 e 30
            ● Acima do peso
            ● Acima de 30 obeso*/

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
