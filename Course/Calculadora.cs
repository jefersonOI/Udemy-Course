using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Calculadora
    {
        public double PI = 3.14;

        public double Circunferencia(double raio)
        {
            return 2.0 * PI * raio;
        }

        public double Volume(double raio)
        {
            return 4.0 / 3.0 * PI * raio * raio * raio;
        }
    }
}
