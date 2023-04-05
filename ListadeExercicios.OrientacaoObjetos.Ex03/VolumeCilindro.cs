using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercicios.OrientacaoObjetos.Ex03
{
    internal class VolumeCilindro
    {
        public double raio;
        public double PI;
        public double altura;

        public double CalcularVolume()
        {
            return Math.PI * raio * raio * altura;

        }

        
    }
}
