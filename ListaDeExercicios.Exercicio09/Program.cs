namespace ListaDeExercicios.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
            #region input de dados
            Console.Write("Insira o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o terceiro valor: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());
            #endregion

            double[] ordemValores = [valor1,valor2,valor3];

            #region processamento
            /* Maneira Manual complicada
             
             if (valor1 > valor2 && valor1 > valor3)       
                maiorValor = valor1;
            else if (valor2 > valor1 && valor2 > valor3)
                maiorValor = valor2;
            else
                maiorValor = valor3;

            if (valor1 < valor2 && valor1 < valor3)
                menorValor = valor1;
            else if (valor2 < valor1 && valor2 < valor3)
                menorValor = valor2;
            else
                menorValor = valor3;


            if (valor1 != maiorValor && valor1 != menorValor)
                medioValor = valor1;
            else if (valor2 != maiorValor && valor2 != menorValor)
                medioValor = valor2;
            else
                medioValor = valor3;*/

            Array.Sort(ordemValores);
            Array.Reverse(ordemValores);
            #endregion

                #region output dos dados
                Console.Write($"Os valores em ordem decrescente é: {ordemValores[0]}, {ordemValores[1]}, {ordemValores[2]}");
            #endregion

            Console.ReadLine();
        }
    }
}
