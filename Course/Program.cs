using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exe1
            Console.Write("Digite um numero entre 1 e 1000: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
            #endregion

            #region Exe2
            Console.Write("Digite um numero inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            int IN = 0;
            int OUT = 0;

            for (int i = 0; i < num2; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                    IN++;
                else
                    OUT++;
            }
            Console.WriteLine(IN + " in");
            Console.WriteLine(OUT + " out");
            #endregion




        }
    }
}
