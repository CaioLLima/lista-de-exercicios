using System.Linq.Expressions;

namespace ListaDeExercicios.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
            resultado.
                a.Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
                b.Pesquise sobre “fatorial”*/
            #region input de dados
            Console.Write("Insira o número para verificar seu fatorial: ");
            string entrada = Console.ReadLine();
            #endregion

            #region processamento
            if (int.TryParse(entrada, out int numero) && numero >= 0)
            {
                int fatorial = 1;
                string expressao = "";
                for (int i = numero; i >= 1; i--)
                {
                    fatorial *= i;
                    expressao += i;

                    if (i > 1)
                        expressao += " x ";
                }

                Console.WriteLine($"{numero}! = {expressao} = {fatorial}");
            }
            else
            {
                Console.WriteLine("Digite um número inteiro válido e não-negativo.");
            }
            #endregion

            #region output dos dados
            
            #endregion

            Console.ReadLine();
        }
    }
}
