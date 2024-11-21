package org.unnath.orientacaoObjetos;

import java.util.Date;
public class Maternidade {

    public Pessoa nascer(String nome, String sexo){
        
        Pessoa pessoa = new Pessoa();
        pessoa.setNome(nome);
        pessoa.setSexo(sexo);
        pessoa.setDataNascimento(new Date());
        return pessoa;
    }
}
