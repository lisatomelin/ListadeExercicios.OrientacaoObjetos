using ListadeExercicios.OrientacaoObjetos.Ex01;

namespace ListadeExercicios.OrientacaoObjetos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de uma caixa retangular

            CaixaRetangular caixa = new CaixaRetangular();
            caixa.altura = 10;
            caixa.comprimento = 20;
            caixa.largura = 30;

            Console.WriteLine(" O volume da caixa é: " + caixa.CalcularVolume());
        }
    }
}