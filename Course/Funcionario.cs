using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Funcionario
    {
        public int FuncionarioID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public void AumentarSalario(double porcentagem)
        {
            Salario += ( Salario * porcentagem / 100);
        }

        public override string ToString()
        {
            return Nome + ", " + Salario.ToString("C2");
        }
    }
}
