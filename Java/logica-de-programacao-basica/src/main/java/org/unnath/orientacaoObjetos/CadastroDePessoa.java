package org.unnath.orientacaoObjetos;

import java.util.ArrayList;

public class CadastroDePessoa {

    ArrayList<Pessoa> pessoaList = new ArrayList<>();
    
    Maternidade maternidade = new Maternidade();
    public static void main(String[] args) {
        new CadastroDePessoa().cadastraPessoa();
    }

    public void cadastraPessoa() {
        Pessoa henrique = maternidade.nascer("Luiz Henrique","Masculino");
        Pessoa unnath = maternidade.nascer("Unnath Silva","Masculino");
        Pessoa joao = maternidade.nascer("João Gabriel","Masculino");
        Pessoa giovanni = maternidade.nascer("Giovanni Araujo","Masculino");
        Pessoa liloka = maternidade.nascer("Lilian Basto","Feminino");
        Pessoa jhann = maternidade.nascer("Janayna Freire","Feminino");
        Pessoa gabriela = maternidade.nascer("Gabriela Silva","Feminino");
        Pessoa robo = maternidade.nascer("R2D2","Android");
        pessoaList.add(gabriela);
        pessoaList.add(jhann);
        pessoaList.add(liloka);
        pessoaList.add(giovanni);
        pessoaList.add(joao);
        pessoaList.add(unnath);
        pessoaList.add(henrique);
        pessoaList.add(robo);

        ArrayList<String> homemList =  new ArrayList<>();
        ArrayList<String> mulherList = new ArrayList<>();
        ArrayList<String> outroGerenoList = new ArrayList<>();
        for (Pessoa pessoa : pessoaList){
            if (pessoa.getSexo().equals("Masculino")){
                homemList.add(pessoa.getNome());
            }else if (pessoa.getSexo().equals("Feminino")){
                mulherList.add(pessoa.getNome());
            }else{
                outroGerenoList.add(pessoa.getNome());
            }
        }
        System.out.println("----------------------------------------------------");
        System.out.println("Homens: " + homemList);
        System.out.println("Mulheres: " + mulherList);
        System.out.println("Outros: " + outroGerenoList);
        System.out.println("----------------------------------------------------");
    }
}
