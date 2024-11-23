using System;

namespace estruturaDeDadosFila
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de Estrutura de Dados - Fila!");

            int capacidade = LerInteiro("Digite a capacidade da fila: ");
            Fila<string> fila = new Fila<string>(capacidade);

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar elemento (Enqueue)");
                Console.WriteLine("2 - Remover elemento (Dequeue)");
                Console.WriteLine("3 - Ver elementos da fila (PrintQueue)");
                Console.WriteLine("4 - Verificar se a fila está vazia (IsEmpty)");
                Console.WriteLine("5 - Verificar se a fila está cheia (IsFull)");
                Console.WriteLine("6 - Limpar a fila (Clear)");
                Console.WriteLine("7 - Sair (Exit)");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine() ?? string.Empty;

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Digite o elemento para adicionar: ");
                            string elemento = Console.ReadLine() ?? string.Empty;
                            if (string.IsNullOrEmpty(elemento))
                            {
                                Console.WriteLine("O elemento não pode ser vazio ou nulo.");
                            }
                            else
                            {
                                fila.Enqueue(elemento);
                                Console.WriteLine($"Elemento '{elemento}' adicionado.");
                            }
                            break;

                        case "2":
                            if (fila.IsEmpty())
                            {
                                Console.WriteLine("A fila está vazia. Não há elementos para remover.");
                            }
                            else
                            {
                                string removido = fila.Dequeue();
                                Console.WriteLine($"Elemento '{removido}' removido.");
                            }
                            break;

                        case "3":
                            Console.WriteLine("Elementos na fila:");
                            fila.PrintQueue();
                            break;

                        case "4":
                            Console.WriteLine(fila.IsEmpty() ? "A fila está vazia." : "A fila não está vazia.");
                            break;

                        case "5":
                            Console.WriteLine(fila.IsFull() ? "A fila está cheia." : "A fila não está cheia.");
                            break;

                        case "6":
                            fila.Clear();
                            Console.WriteLine("A fila foi limpa.");
                            break;

                        case "7":
                            Console.WriteLine("Encerrando o programa...");
                            return; // Sai do método Main, encerrando o programa

                        default:
                            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Método para ler um número inteiro do usuário com validação.
        /// </summary>
        /// <param name="mensagem">Mensagem exibida ao usuário</param>
        /// <returns>Um número inteiro válido</returns>
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
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }
            }
        }
    }
}
