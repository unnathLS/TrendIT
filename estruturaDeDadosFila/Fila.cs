using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        /// <exception cref="ArgumentException">Lan ada se a capacidade for menor ou igual a zero.</exception>
        public Fila(int capacidade)
        {
            if (capacidade <= 0)
                {
                    Console.WriteLine("A capacidade deve ser maior que zero.", nameof(capacidade));
                }
            //Construtor
            primeiro = 0;
            ultimo = 0;
            elementos = new T[capacidade];
        }

        public void Clear()
        {
            //Destrutor
            elementos = -1;
        }
        






    }
}