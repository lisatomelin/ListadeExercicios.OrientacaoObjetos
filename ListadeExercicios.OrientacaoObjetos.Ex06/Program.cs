namespace ListadeExercicios.OrientacaoObjetos.Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) Crie um programa para converter a temperatura da escala Celsius para a
            //escala Fahrenheit

            ConversaoTemperatura temperatura = new ConversaoTemperatura();

            temperatura.Fahrenheit = 0;
            temperatura.Celsius = 100;

            Console.WriteLine("A temperatura em Fahrenheit é: " + temperatura.CalcularTemperatura());


        }
    }   
}