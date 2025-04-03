namespace ListaDeExercicios.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
            #region input de dados
            Console.Write("Insira o primeiro valor(A): ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o segundo valor(B): ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o terceiro valor(C): ");
            double valor3 = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            if (valor1 + valor2 < valor3)
                Console.Write($"A soma de A={valor1} + B={valor2} = {valor1 + valor2} é menor que o valor C={valor3}.");
            else if (valor1 + valor2 > valor3)
                Console.WriteLine($"A soma de A + B={valor2} = {valor1 + valor2} é maior que o valor C={valor3}.");
            else
                Console.WriteLine("Valores inválidos");
                #endregion

                Console.ReadLine();
        }
    }
}
