namespace ListaDeExercicios.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
                múltiplos de 3 pela palavra "Fizz" e os múltiplos de 5 pela palavra "Buzz". Para números que são múltiplos de
                ambos, use "FizzBuzz".*/

            #region input de dados

            #endregion

            #region processamento
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write($"FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write($"Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write($"Buzz ");
                }

                Console.Write($"{i} ");
            }
            #endregion

            #region output dos dados
           
            #endregion

            Console.ReadLine();
        }
    }
}
