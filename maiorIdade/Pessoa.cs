using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maiorIdade
{
     public class Pessoa
    {
        private Dictionary<string, int> dicionarioPessoas = new Dictionary<string, int>();
        
        // Propriedades Nome e Idade
        private string _nome = string.Empty;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value.ToUpper(); }
        }

        private int _idade;
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        // Método para capturar a quantidade de pessoas
        public void QuantidadePessoa()
        {
            int numeroDePessoas;
            Console.WriteLine("Digite quantas pessoas vamos comparar idade: ");
            while (!int.TryParse(Console.ReadLine(), out numeroDePessoas) || numeroDePessoas <= 0)
            {
                Console.WriteLine("Por favor, digite um número válido para o número de pessoas (deve ser maior que 0): ");
            }

            // Adicionando as pessoas no dicionário
            for (int i = 1; i <= numeroDePessoas; i++)
            {
                Console.WriteLine($"Digite o nome da pessoa {i}:");
                var nomePessoa = Console.ReadLine();

                Console.WriteLine($"Digite a idade da pessoa {i}:");
                var idadePessoa = Convert.ToInt32(Console.ReadLine());

                // Adicionando no dicionário (nomes em maiúsculas para padronização)
                dicionarioPessoas.Add(nomePessoa, idadePessoa);
            }
        }

        // Exibindo os dados e as pessoas mais velha e mais nova
        public void ExibirDados(string maisVelho, string maisNovo, int idadeMaisVelho, int idadeMaisNovo)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\nPessoas cadastradas: ");

            foreach (var pessoa in dicionarioPessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Key} - Idade: {pessoa.Value}");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\nPessoa mais velha: ");
            Console.WriteLine($"Nome: {maisVelho} - Idade: {idadeMaisVelho}");
            Console.WriteLine("\nPessoa mais nova: ");
            Console.WriteLine($"Nome: {maisNovo} - Idade: {idadeMaisNovo}");
        }

        // Método para comparar idades
        public (string maisVelho, string maisNovo, int idadeMaisVelho, int idadeMaisNovo) ComparaIdades()
        {
            if (dicionarioPessoas.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa cadastrada");
                return (null, null, 0, 0);
            }

            // Inicializando as variáveis
            string maisVelho = null;
            string maisNovo = null;
            int idadeMaisVelho = int.MinValue; // Usando o valor mínimo de idade
            int idadeMaisNovo = int.MaxValue; // Usando o valor máximo de idade

            // Comparando as idades
            foreach (var pessoa in dicionarioPessoas)
            {
                if (pessoa.Value > idadeMaisVelho)
                {
                    idadeMaisVelho = pessoa.Value;
                    maisVelho = pessoa.Key;
                }
                if (pessoa.Value < idadeMaisNovo)
                {
                    idadeMaisNovo = pessoa.Value;
                    maisNovo = pessoa.Key;
                }
            }

            // Retornando uma tupla com os resultados
            return (maisVelho, maisNovo, idadeMaisVelho, idadeMaisNovo);
        }
    }
}