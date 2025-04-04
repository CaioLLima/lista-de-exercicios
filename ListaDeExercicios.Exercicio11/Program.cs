using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListaDeExercicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

            #region input de dados
            Console.Write("Insira um número para verifica se é par ou ímpar: ");
            double parOuImpar = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            /*if (parOuImpar % 2 == 0)
            {
                Console.WriteLine($"O número {parOuImpar} é par.");
            } else
                Console.WriteLine($"O número {parOuImpar} é ímpar.");*/
            #endregion

            #region output dos dados 
            Console.WriteLine(parOuImpar % 2 == 0 ? ($"O número {parOuImpar} é par.") : ($"O número {parOuImpar} é ímpar.")); //expressão ternária
            #endregion

            Console.ReadLine();
        }
    }
}
