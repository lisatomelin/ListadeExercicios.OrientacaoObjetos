using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercicios.OrientacaoObjetos.Ex02
{
    internal class Conversaotemperatura
    {
        public double Fahrenheit;
        public double Celsius;

        public double CalcularTemperatura()
        {
            return (Fahrenheit - 32) * 5 / 9;
        }
    }
}
