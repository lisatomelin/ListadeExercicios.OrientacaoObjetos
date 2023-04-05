namespace ListadeExercicios.OrientacaoObjetos.Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de uma lata de óleo


            VolumeLatadeOleo volume = new VolumeLatadeOleo();

            volume.altura = 10;
            volume.raio =10;
           

            Console.WriteLine("O volume da lata é: " + volume.Calculodovolume());
        }
    }
}