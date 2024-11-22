using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        //   private string TextoMensagem = string.Empty;

        //   public string getMensagem(){
        //       return this.TextoMensagem;
        //   }
        //   public void setMensagem(string valor){
        //     this.TextoMensagem = valor.ToUpper();
        //   }

        private string Mensagem1 = string.Empty;
        public string TextoMensagem
        {
            get { return this.Mensagem1; }
            set { this.Mensagem1 = value.ToUpper(); }
        }
        public void ExibirMensagem()
        {
            Console.WriteLine(TextoMensagem);
        }
    }
}