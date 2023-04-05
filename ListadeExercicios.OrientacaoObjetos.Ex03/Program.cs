using System.Security.Cryptography.X509Certificates;

namespace ListadeExercicios.OrientacaoObjetos.Ex03
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            VolumeCilindro volume = new VolumeCilindro();

            volume.raio = 100;
            volume.altura = 100;
            volume.PI = Math.PI;
            

            Console.WriteLine("O volume do cilindro é: " + volume.CalcularVolume());

        }

    } 
}   
    
 
      




        
    
