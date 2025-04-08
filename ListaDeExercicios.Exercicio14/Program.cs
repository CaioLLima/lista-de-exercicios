namespace ListaDeExercicios.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

            #region input de dados
            Console.Write("Insira um número para a sequência de Fibonacci ir até esse número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            int soma1 = 0;
            int soma2 = 1;
            int resultado = 0;
            #endregion

            #region processamento
            Console.Write($"{soma1} ");
            Console.Write($"{soma2} ");

            while (resultado < numero)
            {
                resultado = soma1 + soma2;
                if (resultado > numero)
                    break;
                Console.Write($"{resultado} ");
                soma1 = soma2;
                soma2 = resultado;
                
            }
            #endregion

            #region output dos dados

            #endregion

            Console.ReadLine();
        }
    }
}
