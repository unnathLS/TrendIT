using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {
        private string nome = string.Empty;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }
        private int idade;
        public int Idade
        {
            get {
                 this.IdadeResultado();
                 return this.idade; 
                }
        }
        private int anoNascimento;
        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }
        public void ExibirDados(){
            // this.IdadeResultado();
            Console.WriteLine("Nome: " + Nome + "\n" + "Idade: " + this.Idade);
        }
        public void IdadeResultado(){
            DateTime data = DateTime.Now;
            int ano = data.Year;
            this.idade = ano - this.AnoNascimento;
        }
    }
}