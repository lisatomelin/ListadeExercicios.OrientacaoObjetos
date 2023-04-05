using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercicios.OrientacaoObjetos.Ex04
{
    internal class ConsumodeCombustivel
    {
        public double kminicial;
        public double kmfinal;
        public double consumodecombustivel;
        public double Calcularconsumo()
        {
            return consumodecombustivel / (kmfinal - kminicial);
        }
    }
}
