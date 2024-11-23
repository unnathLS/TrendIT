using System;

namespace estruturaDeDadosFila
{
    public class Fila<T>
    {
        private T[] elementos;
        private int primeiro;
        private int ultimo;

        /// <summary>
        /// Inicializa uma nova instancia da classe Fila com a capacidade especificada.
        /// </summary>
        /// <param name="capacidade">A capacidade maxima da fila.</param>
        /// <exception cref="ArgumentException">Lançada se a capacidade for menor ou igual a zero.</exception>
        public Fila(int capacidade)
        {
            if (capacidade <= 0)
            {
                throw new ArgumentException("A capacidade deve ser maior que zero.", nameof(capacidade));
            }

            primeiro = 0;
            ultimo = 0;
            elementos = new T[capacidade];
        }

        /// <summary>
        /// Remove todos os elementos da fila.
        /// </summary>
        public void Clear()
        {
            elementos = new T[elementos.Length];
            primeiro = 0;
            ultimo = 0;
        }


        /// <summary>
        /// Verifica se a fila est  vazia.
        /// </summary>
        /// <returns>Verdadeiro se a fila estiver vazia; caso contr rio, falso.</returns>
        public bool IsEmpty()
        {
            return primeiro == ultimo;
        }

        /// <summary>
        /// Verifica se a fila est  cheia.
        /// </summary>
        /// <returns>Verdadeiro se a fila estiver cheia; caso contr rio, falso.</returns>
        public bool IsFull()
        {
            return (ultimo + 1) % elementos.Length == primeiro % elementos.Length;
        }

        /// <summary>
        /// Adiciona um elemento na fila.
        /// </summary>
        /// <param name="elemento">O elemento a ser adicionado.</param>
        /// <exception cref="InvalidOperationException">Lan adia se a fila estiver cheia.</exception>
        public void Enqueue(T elemento)
        {
            if (!IsFull())
            {
                elementos[ultimo % elementos.Length] = elemento;
                ultimo++;
            }
            else
            {
                Console.WriteLine("Fila cheia");
            }
        }

        /// <summary>
        /// Remove e retorna o elemento do in cio da fila.
        /// </summary>
        /// <returns>O elemento removido do in cio da fila.</returns>
        /// <exception cref="InvalidOperationException">Lan adia se a fila estiver vazia.</exception>
        public T Dequeue()
        {
            if (!IsEmpty())
            {
                T elementoRemovido = elementos[primeiro % elementos.Length];
                primeiro++;
                return elementoRemovido;
            }
            else
            {
                throw new InvalidOperationException("Fila vazia");
            }
        }

       
        // public T Peek()
        // {
        //     if (!IsEmpty())
        //     {
        //         return elementos[primeiro % elementos.Length];
        //     }
        //     else
        //     {
        //         throw new InvalidOperationException("Fila vazia");
        //     }
        // }

        /// <summary>
        /// Imprime todos os elementos da fila na ordem em que foram adicionados.
        /// </summary>
        public void PrintQueue()
        {
            if(!IsEmpty())
            {
                for (int i = primeiro; i < ultimo; i++)
            {
                Console.WriteLine(elementos[i % elementos.Length]);
            }
            }
            else
            {
                Console.WriteLine("Fila vazia");
            }
        }
    }
}
