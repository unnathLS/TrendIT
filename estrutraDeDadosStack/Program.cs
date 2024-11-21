using System;

namespace estrutraDeDadosStack
{
    class Program
    {
        /// <summary>
        /// Ponto de entrada para o programa de pilha, que oferece uma interface baseada em menu
        /// para interagir com uma pilha de strings. Os usuários podem realizar operações como
        /// adicionar elementos (push), remover elementos (pop), visualizar o elemento no topo (peek),
        /// verificar se a pilha está vazia, contar os elementos, limpar a pilha e sair do programa.
        /// </summary>
        /// <param name="args">Argumentos da linha de comando (não utilizados).</param>

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de Pilha!");

            int capacidade = LerInteiro("Digite a capacidade da pilha: ");
            Pilha<string> pilha = new Pilha<string>(capacidade);

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar elemento (Push)");
                Console.WriteLine("2 - Remover elemento (Pop)");
                Console.WriteLine("3 - Ver elemento no topo (Peek)");
                Console.WriteLine("4 - Verificar se a pilha está vazia");
                Console.WriteLine("5 - Ver número de elementos na pilha");
                Console.WriteLine("6 - Limpar pilha");
                Console.WriteLine("7 - Sair");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine() ?? string.Empty;

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Digite o elemento para adicionar: ");
                            string elemento = Console.ReadLine() ?? string.Empty;
                            if (string.IsNullOrWhiteSpace(elemento))
                            {
                                Console.WriteLine("O elemento não pode ser vazio.");
                            }
                            else
                            {
                                pilha.Push(elemento);
                                Console.WriteLine($"Elemento '{elemento}' adicionado.");
                            }
                            break;

                        case "2":
                            string removido = pilha.Pop();
                            Console.WriteLine($"Elemento '{removido}' removido.");
                            break;

                        case "3":
                            string topo = pilha.Peek();
                            Console.WriteLine($"Elemento no topo: '{topo}'.");
                            break;

                        case "4":
                            Console.WriteLine(pilha.IsEmpty() ? "A pilha está vazia." : "A pilha não está vazia.");
                            break;

                        case "5":
                            Console.WriteLine($"Número de elementos na pilha: {pilha.Count()}.");
                            break;

                        case "6":
                            pilha.Clear();
                            Console.WriteLine("Pilha limpa.");
                            break;

                        case "7":
                            Console.WriteLine("Saindo...");
                            return;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Método auxiliar para ler e validar entradas inteiras.
        /// </summary>
        /// <param name="mensagem">Mensagem a ser exibida no terminal.</param>
        /// <returns>Um número inteiro válido.</returns>
        private static int LerInteiro(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine() ?? "0";

                if (int.TryParse(entrada, out int resultado))
                {
                    return resultado;
                }

                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        }
    }
}
