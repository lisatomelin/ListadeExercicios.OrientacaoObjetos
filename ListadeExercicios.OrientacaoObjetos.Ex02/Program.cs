namespace ListadeExercicios.OrientacaoObjetos.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para converter a temperatura de graus Fahrenheit para graus
            //Celsius

            Conversaotemperatura temperatura = new Conversaotemperatura();

            temperatura. Fahrenheit = 100;
            temperatura.Celsius = 0;

            Console.WriteLine("A temperatura em Celsius é: " + temperatura.CalcularTemperatura());

        }
    }
}