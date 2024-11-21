package org.unnath.logica;

public class EstrturaDeDecisao {
    
    public static void main(String[] args) {
        System.out.println("----------------------------------------------------");
        diaSemana();
        System.out.println("----------------------------------------------------");
        stringInicia();
        System.out.println("----------------------------------------------------");
    }


    public static void diaSemana() {
        String dia = "Hoje eh sexta feira";
    System.out.print("----------------------------------------------------");
        if (dia.contains("segunda feira")) {
            System.out.println("Tristeza maxima");
        } else if (dia.contains("terça feira")) {
            System.out.println("Tristeza maxima");
        } else if (dia.contains("quarta feira")) {
            System.out.println("Tristeza media");
        } else if (dia.contains("quinta feira")) {
            System.out.println("Tristeza minima");
        } else if (dia.contains("sexta feira")) {
            System.out.println("Alegria maxima");
        } else if (dia.contains("sabado")) {
            System.out.println("Alegria media");
        } else {
            System.out.println("Alegria minima");
        }
    }

    public static void stringInicia() {
        String letra = "a";
        if (letra.startsWith("a")) {
            System.out.println("Inicia com a");
        }else{
            System.out.println("Não inicia com a");
        }
    }

}
