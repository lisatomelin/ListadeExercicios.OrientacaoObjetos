using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercicios.OrientacaoObjetos.Ex06
{
    internal class ConversaoTemperatura
    {

        public double Fahrenheit;
        public double Celsius;

        public double CalcularTemperatura()
        {
            return (Celsius * 9 / 5) + 32;
        }
    }
}
