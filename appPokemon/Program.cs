using System;

namespace appPokemon
{
    public class Program
    {
        public static void Main()
        {
            Pokedex minhaPokedex = new Pokedex("", "");

            // Carregar Pokémons salvos
            minhaPokedex.CarregarPokemons();

            // Adicionar novos Pokémons
            minhaPokedex.InputPokemon();

            // Listar todos os Pokémons
            minhaPokedex.ListarPokemons();

            // Salvar os Pokémons no arquivo
            minhaPokedex.SalvarPokemons();
        }
    }
}