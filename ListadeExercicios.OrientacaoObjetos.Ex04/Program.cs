namespace ListadeExercicios.OrientacaoObjetos.Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Crie um programa para calcular o consumo de combustível por Km. Deverá ser
            //informado a kilometragem Inicial e Final do Percurso do Veículo.Deverá ser
            //informado o Consumo de Combustível

            ConsumodeCombustivel consumo = new ConsumodeCombustivel();

            consumo.kminicial = 50;
            consumo.kmfinal = 100;
            consumo.consumodecombustivel = 500;
            

            Console.WriteLine("O consumo de combustivel por km é de: " + consumo.Calcularconsumo());



        }
    }
}