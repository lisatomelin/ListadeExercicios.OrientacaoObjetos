using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeExercicios.OrientacaoObjetos.Ex09
{
    internal class MediaHarmonica
    {
        public int numerodenotas;
        public double somainversonotas;
        public double notas;

        public double CalcularMedia()
        {
            return numerodenotas / somainversonotas;


        }

        public double Calcularsomainversa()
        {
            
            for (int i = 1; i <= numerodenotas; i++)
            {
                Console.Write($"Digite a nota {i}: ");
                double nota = double.Parse(Console.ReadLine());
                somainversonotas += 1.0 / nota;

            }

            
            return somainversonotas;
        }
    }
}
