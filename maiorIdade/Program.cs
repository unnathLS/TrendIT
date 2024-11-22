using System;

namespace maiorIdade
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Pessoa pessoa = new Pessoa();
            
            // Chamando os métodos
            pessoa.QuantidadePessoa();

            // Chamando o método para comparar idades e obter os resultados
            var (maisVelho, maisNovo, idadeMaisVelho, idadeMaisNovo) = pessoa.ComparaIdades();

            // Exibindo os dados
            pessoa.ExibirDados(maisVelho, maisNovo, idadeMaisVelho, idadeMaisNovo);
        }
    }
}