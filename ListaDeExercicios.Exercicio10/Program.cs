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
            Console.Write("Informe seu peso em kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe sua altura em cm: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            altura /= 100;
            double imc = peso / Math.Pow(altura, 2);

            if (imc <= 18.5) 
                Console.Write($"Seu IMC é: {imc}. Você está abaixo do peso ideal."); 
            else if (imc > 18.5 && imc <= 25)
                Console.Write($"Seu IMC é: {imc}. Você está com o peso ideal."); 
            else if (imc > 25 && imc <= 30)
                Console.Write($"Seu IMC é: {imc}. Você está acima do peso ideal."); 
            else 
                Console.Write($"Seu IMC é: {imc}. Você está comletamento obeso.");
            #endregion


            Console.ReadLine();
        }
    }
}
