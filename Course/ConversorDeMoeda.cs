using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class ConversorDeMoeda
    {
        public static int ValorIOF = 6;

        public static double CustoDolar(double cotacaoDolar, double valorAComprar)
        {
            double valorBrutoDolar = cotacaoDolar * valorAComprar;
            return valorBrutoDolar + valorBrutoDolar * ValorIOF / 100.0;
        }
    }
}
