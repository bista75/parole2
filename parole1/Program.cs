using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parole1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire una parola");
            string frase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(frase))
            {
                Console.WriteLine("riprova");
            }
            else
            {
                string[] parole = frase.Split(' ');
                Console.WriteLine("Numero di parole: " + parole.Length);
            }
        }
    }
}
