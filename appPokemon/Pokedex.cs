using System;
using System.Collections.Generic;
using System.IO;

namespace appPokemon
{
    public class Pokedex
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }

        // Construtor para inicializar os Pokémon
        public Pokedex(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        // Lista de Pokémon
        private List<Pokedex> _pokemons = new List<Pokedex>();

        // Método para adicionar Pokémon à lista
        public void AdicionarPokemon(string nome, string tipo)
        {
            Pokedex novoPokemon = new Pokedex(nome, tipo);
            _pokemons.Add(novoPokemon);
            System.Console.WriteLine("-----------------------------------------------------");
            // Console.WriteLine($"Pokémon {nome} do tipo {tipo} foi adicionado com sucesso!");
            // System.Console.WriteLine("-----------------------------------------------------");
        }

        // Método para capturar os dados do usuário e adicionar o Pokémon
        public void InputPokemon()
        {
            Console.WriteLine("Digite o nome do Pokémon: ");
            string inputNome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Digite o tipo do Pokémon: ");
            string inputTipo = Console.ReadLine() ?? string.Empty;

            if (!string.IsNullOrEmpty(inputNome) && !string.IsNullOrEmpty(inputTipo))
            {
                string nomeFormatado = char.ToUpper(inputNome[0]) + inputNome.Substring(1).ToLower();
                string tipoFormatado = char.ToUpper(inputTipo[0]) + inputTipo.Substring(1).ToLower();
                AdicionarPokemon(nomeFormatado, tipoFormatado);
            }
            else
            {
                Console.WriteLine("Nenhuma entrada foi fornecida!");
            }
        }

        // Método para listar todos os Pokémon
        public void ListarPokemons()
        {
            Console.WriteLine("\nLista de Pokémons:");
            foreach (var pokemon in _pokemons)
            {
                Console.WriteLine($"- Nome: {pokemon.Nome}, Tipo: {pokemon.Tipo}");
            }
        }

        // Salvar Pokémon no arquivo
        public void SalvarPokemons()
        {
            using (StreamWriter writer = new StreamWriter("pokemons.txt"))
            {
                foreach (var pokemon in _pokemons)
                {
                    writer.WriteLine($"Nome do Pokemon: {pokemon.Nome} , Tipo do Pokemon: {pokemon.Tipo}");
                }
            }
            Console.WriteLine("Pokémons salvos com sucesso!");
        }

        // Carregar Pokémon do arquivo
        public void CarregarPokemons()
        {
            if (File.Exists("pokemons.txt"))
            {
                using (StreamReader reader = new StreamReader("pokemons.txt"))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(',');
                        if (dados.Length == 2)
                        {
                            string nome = dados[0].Trim();
                            string tipo = dados[1].Trim();
                            AdicionarPokemon(nome, tipo);
                        }
                    }
                }
                Console.WriteLine("Pokémons carregados com sucesso!");
            }
            else
            {
                Console.WriteLine("Nenhum arquivo de Pokédex encontrado.");
            }
        }
    }
}
