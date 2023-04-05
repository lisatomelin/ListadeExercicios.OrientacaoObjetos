namespace ListadeExercicios.OrientacaoObjetos.Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular a média harmônica das notas de um
            //aluno

            MediaHarmonica media = new MediaHarmonica();

            media.numerodenotas = 0;
            media.somainversonotas = 0;
            media.notas = 0;

            Console.WriteLine("Digite o quantas notas deseja calcular: ");
            media.numerodenotas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as notas:");
            media.notas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A soma inversa das notas é: " + media.Calcularsomainversa());


            Console.WriteLine("A média Harmonica é: " + media.CalcularMedia());
        }
    }
}