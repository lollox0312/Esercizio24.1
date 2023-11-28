using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato q = new Quadrato();
            Console.WriteLine("inserisci il lato del quadrato");
            q.Lato = float.Parse(Console.ReadLine());
            Console.WriteLine("la superfice del quadrato è: {0}", q.Lato*q.Lato);
            Console.ReadLine();
        }
    }
}
