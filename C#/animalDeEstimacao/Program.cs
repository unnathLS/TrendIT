using System;

namespace animalDeEstimacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando o AnimalController
            AnimalController a = new AnimalController();
            
            // Obtendo o nome do dono do animal
            Console.WriteLine("Digite o seu nome:");
            a.Nome = Console.ReadLine() ?? "Nome padrão";  // Usamos o operador de coalescência nula para garantir que o nome nunca seja nulo

            // Obtendo a quantidade de animais
            Console.WriteLine("Quantos pets você tem no momento?");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int resultado))
            {
                a.Animal = resultado;  // Atribui a quantidade de animais
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

            // Coleta os nomes dos animais
            a.ColetarNomesAnimais();

            // Exibindo os dados do controlador
            a.ExibirDados();
        }
    }
}