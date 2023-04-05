using System.Net.Http.Headers;

namespace ListadeExercicios.OrientacaoObjetos.Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular a média ponderada de duas provas
            //realizadas por um aluno

            MediaPonderada media = new MediaPonderada();

            Console.WriteLine("Digite o valor da primeira nota:");
            media.nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda nota:");
            media.nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do primeiro peso:");
            media.peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo peso:");
            media.peso2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A média ponderada das duas notas é:" + media.Calcularmediaponderada());
        }
    }
}