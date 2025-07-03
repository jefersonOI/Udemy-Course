using Course;
using System;
using System.Globalization;

namespace ourse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }


            double avg = sum / n;
            Console.WriteLine("Media de altura " + avg.ToString("F2"));
        }
    }
}