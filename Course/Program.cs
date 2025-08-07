using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();  

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Ana");
            lista.Insert(2, "Marco");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Lista tem -> " + lista.Count);

            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("primeiro A: " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo A: " + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeiro A na posicao: " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultimo A na posicao: " + pos2);

            Console.WriteLine("--------------");

            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            foreach (string item in lista2)
            {
                Console.WriteLine("Lista2: " + item);
            }

            Console.WriteLine("-----------");
            lista.Remove("Alex");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------");

            lista.RemoveAll(x => x[0] == 'M');

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }




        }
    }
}