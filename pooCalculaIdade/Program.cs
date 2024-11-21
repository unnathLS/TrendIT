using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace pooCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Programa que Calcula a idade de uma Pessoa:");
            Pessoa p = new Pessoa();
            System.Console.WriteLine("Digite o Nome da Pessoa: ");
            var inputNome = Console.ReadLine();
            p.Nome = string.IsNullOrEmpty(inputNome) ? "Nome não informado" : inputNome;
            System.Console.WriteLine("Digite o Ano de Nascimento  da Pessoa:");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            p.ExibirDados();
        }   
    }
}