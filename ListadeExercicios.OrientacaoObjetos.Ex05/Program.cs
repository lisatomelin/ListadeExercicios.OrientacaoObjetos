namespace ListadeExercicios.OrientacaoObjetos.Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Crie um programa para calcular o volume de uma esfera

            VolumeEsfera volume = new VolumeEsfera();

            volume.raio = 0;
            volume.PI = Math.PI;


            Console.WriteLine("O volume da esfera é: " + volume.CalcularVolume());

        }
    }
}