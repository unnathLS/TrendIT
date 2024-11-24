using System;

namespace estruturaDeDadosListaEncadeada
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class Lista
    {
        private Node? head;

        /// <summary>
        /// Adiciona um novo nó com o dado especificado ao final da lista ligada.
        /// </summary>
        /// <param name="data">O dado inteiro a ser armazenado no novo nó.</param>
        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        /// <summary>
        /// Exibe os elementos da lista ligada na ordem em que aparecem no console.
        /// Os elementos são separados por " -> " e o final da lista é marcado com "null".
        /// </summary>
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        /// <summary>
        /// Remove o nó com o dado especificado da lista ligada.
        /// </summary>
        /// <param name="data">O dado inteiro a ser removido da lista ligada.</param>
        public void Remove(int data)
        {
            if (head == null) return;

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }
    }
}
