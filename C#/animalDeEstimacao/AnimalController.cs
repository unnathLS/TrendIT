using System;
using System.Collections.Generic;

namespace animalDeEstimacao
{
    public class AnimalController
    {
        private string _nome = string.Empty;
        public string Nome
        {
            get => _nome;
            set => _nome = value ?? "Nome padrão"; // Garante que nunca será nulo
        }

        private string _animalTipo = string.Empty;
        public string AnimalTipo
        {
            get => _animalTipo;
            set => _animalTipo = value ?? "desconhecido"; // Garante que nunca será nulo
        }

        private int _animal;
        public int Animal
        {
            get => _animal;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Você não tem nenhum animal.");
                    _animal = 0;
                }
                else
                {
                    _animal = value;
                }
            }
        }

        // Lista de nomes dos animais
        private List<string> listaAnimais = new List<string>();

        // Método para coletar os nomes dos animais
        public void ColetarNomesAnimais()
        {
            listaAnimais.Clear();  // Limpa a lista de animais antes de coletar novos nomes
            for (int i = 0; i < _animal; i++)
            {
                listaAnimais.Add(InputAnimalNome(i));  // Passando o index para identificar o animal
            }
        }

        // Método para ler o nome de um animal
        public string InputAnimalNome(int index)
        {
            Console.WriteLine($"Qual pet você tem:  {index + 1}:");
            var input = Console.ReadLine();
            input = input?.ToLower();  // Certifica-se de que o nome esteja em minúsculas

            // Caso o nome esteja vazio ou nulo, usamos "Animal sem nome" como padrão
            return string.IsNullOrEmpty(input) ? "não informado" : input;
        }

        // Método para exibir dados do usuário
        public void ExibirDados()
        {
            System.Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Quantidade de pets: {Animal}");
            // Console.WriteLine($"Que são: {AnimalTipo}");

            // Exibe a lista de animais
            Console.WriteLine("Lista de Animais:");
            foreach (var animal in listaAnimais)
            {
                Console.WriteLine($"- {animal}");
            }
        }
    }
}


