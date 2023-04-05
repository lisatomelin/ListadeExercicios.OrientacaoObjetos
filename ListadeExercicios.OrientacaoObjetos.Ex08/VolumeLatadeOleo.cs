using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ListadeExercicios.OrientacaoObjetos.Ex08
{
    internal class VolumeLatadeOleo
    {
        public double volume;
        public double raio;
        public double altura;
        

        public double Calculodovolume()
        {
            return Math.PI* Math.Pow(raio, 2) * altura;
        }
    }
}
