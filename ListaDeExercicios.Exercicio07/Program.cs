namespace ListaDeExercicios.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para verificar se um número é primo.
            #region input de dados
            Console.Write("Insira um número para verificar se é primo: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region processamento
            bool ehPrimo(int numero)
            {
                if (numero <= 1)
                    return false;
           
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                        return false;
                }               
                return true;
            }
            #endregion

            #region output dos dados
            if (ehPrimo(numero))
                Console.WriteLine($"O número {numero} é primo.");
            else
                Console.WriteLine($"O número {numero} não é primo.");
            #endregion

            Console.ReadLine();
        }
    }
}
