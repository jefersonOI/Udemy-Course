using Course;
using System;
using System.Globalization;

namespace ourse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = new string[] {"maria", "bob","joao" } ;

            for (int i = 0 ; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            Console.WriteLine("----------------------------");

            foreach(string obj in valores)
            {
                Console.WriteLine(obj);
            }
        }
    }
}