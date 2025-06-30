using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public bool Aprovado;

        public double CalcularNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool AprovadoOuReprovado()
        {
            double notaFinal = CalcularNotaFinal();

            if (CalcularNotaFinal() >= 60)
                return true;
            else
                return false;
        }

        public double CalcularNotaFaltante()
        {
            return 60.0 - CalcularNotaFinal();
        }
    }
}
