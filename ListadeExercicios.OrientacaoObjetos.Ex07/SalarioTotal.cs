using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercicios.OrientacaoObjetos.Ex07
{
    internal class SalarioTotal
    {
        public double salario;
        public double totalvendas;
        public double percentual;

        public double CalculoSalarioTotal()
        {
            return (percentual / 100) * totalvendas + salario;
        }
    }
}
