namespace ListaDeExercicios.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

            #region input de dados
            Console.WriteLine("Gerando números ímpares entre 100 e 200.");

            #endregion

            #region processamento
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine($"O número {i} é ímpar.");
            }
            #endregion

            #region output dos dados
            
            #endregion

            Console.ReadLine();
        }
    }
}
