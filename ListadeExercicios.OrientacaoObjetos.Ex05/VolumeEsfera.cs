using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercicios.OrientacaoObjetos.Ex05
{
    internal class VolumeEsfera
    {
        public double raio;
        public double PI;
        public double  CalcularVolume()
        {
            return 4 * Math.PI * raio * raio * raio / 3;
        }

        
    }
}
