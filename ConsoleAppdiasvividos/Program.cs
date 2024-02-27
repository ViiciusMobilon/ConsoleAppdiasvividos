using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppdiasvividos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos você tem");
             int anos = int.Parse (Console.ReadLine());

            Console.WriteLine("Qual sua idade em mes");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua idade em dias");
           int dia = int.Parse(Console.ReadLine());


            
            int f = (anos * 365) + (mes * 30) + dia;

            Console.WriteLine("Sua idade em dias é:" + f);
            Console.ReadKey();





        }
    }
}
