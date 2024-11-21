using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pooMensagem
{
     class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Hello World";
            msg1.ExibirMensagem();
            // msg1.setMensagem("Meu nome é luiz henrique");
            // msg1.ExibirMensagem();
            
        }
    }
}

