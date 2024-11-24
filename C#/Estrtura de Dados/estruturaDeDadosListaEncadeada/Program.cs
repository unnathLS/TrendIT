using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estruturaDeDadosListaEncadeada
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.Add(10);
            lista.Add(20);
            lista.Add(30);
            lista.Add(40);
            lista.Add(50);

            Console.WriteLine("Exibindo a lista:");
            lista.Display();    // Exibe a lista ligada
            Console.WriteLine("Removendo o elemento 20 ...");
            lista.Remove(20);
            Console.WriteLine("Exibindo a lista:");
            lista.Display();
            
        }
    }
}