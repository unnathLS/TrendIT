using System;

namespace estrutraDeDadosStack
{
    /// <summary>
    /// Representa uma estrutura de dados do tipo Pilha (Stack).
    /// </summary>
    /// <typeparam name="T">O tipo dos elementos armazenados na pilha.</typeparam>
    public class Pilha<T>
    {
        private T[] elementos;
        private int topo;

        /// <summary>
        /// Inicializa uma nova instância da classe Pilha com a capacidade especificada.
        /// </summary>
        /// <param name="capacidade">A capacidade máxima da pilha.</param>
        /// <exception cref="ArgumentException">Lançada se a capacidade for menor ou igual a zero.</exception>
        public Pilha(int capacidade)
        {
            if (capacidade <= 0)
            {
                throw new ArgumentException("A capacidade deve ser maior que zero.", nameof(capacidade));
            }

            elementos = new T[capacidade];
            topo = -1;
        }

        /// <summary>
        /// Adiciona um elemento ao topo da pilha.
        /// </summary>
        /// <param name="elemento">O elemento a ser adicionado.</param>
        /// <exception cref="InvalidOperationException">Lançada se a pilha estiver cheia.</exception>
        public void Push(T elemento)
        {
            if (topo < elementos.Length - 1)
            {
                elementos[++topo] = elemento;
            }
            else
            {
                throw new InvalidOperationException("Pilha cheia.");
            }
        }

        /// <summary>
        /// Remove e retorna o elemento do topo da pilha.
        /// </summary>
        /// <returns>O elemento removido do topo da pilha.</returns>
        /// <exception cref="InvalidOperationException">Lançada se a pilha estiver vazia.</exception>
        public T Pop()
        {
            VerificarSeVazia();
            return elementos[topo--];
        }

        /// <summary>
        /// Retorna o elemento do topo da pilha sem removê-lo.
        /// </summary>
        /// <returns>O elemento do topo da pilha.</returns>
        /// <exception cref="InvalidOperationException">Lançada se a pilha estiver vazia.</exception>
        public T Peek()
        {
            VerificarSeVazia();
            Console.WriteLine(topo);
            return elementos[topo];
        }

        /// <summary>
        /// Verifica se a pilha está vazia.
        /// </summary>
        /// <returns>Verdadeiro se a pilha estiver vazia; caso contrário, falso.</returns>
        public bool IsEmpty()
        {
            return topo == -1;
        }

        /// <summary>
        /// Retorna o número de elementos na pilha.
        /// </summary>
        /// <returns>O número de elementos na pilha.</returns>
        public int Count()
        {
            return topo + 1;
        }

        /// <summary>
        /// Remove todos os elementos da pilha.
        /// </summary>
        public void Clear()
        {
            topo = -1;
        }

        /// <summary>
        /// Obtém a capacidade máxima da pilha.
        /// </summary>
        public int Capacity => elementos.Length;

        private void VerificarSeVazia()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Pilha vazia.");
            }
        }
    }
}
