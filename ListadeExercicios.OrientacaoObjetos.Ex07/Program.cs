namespace ListadeExercicios.OrientacaoObjetos.Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o salário total de um vendedor. Deverá ser
            //informado o salário base e o total de vendas.A comissão é calculada com um
            //percentual(informado pelo usuário) sobre o total de vendas

            SalarioTotal calculo = new SalarioTotal();

            calculo.salario = 1000;
            calculo.totalvendas = 5000;
            calculo.percentual = 1;

            Console.WriteLine("O salário Total é: " + calculo.CalculoSalarioTotal());

        }
    }
}