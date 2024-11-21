package org.unnath.logica;

import java.util.ArrayList;

public class DecisaoRepeticaoJuntos {
    public static void main(String[] args) {
        imprimeParesEImpares();

    }

    public static void imprimeParesEImpares() {
        ArrayList<Integer> listaDeUmADez = new ArrayList<>();

        for (int i = 0; i <= 10; i++) {
            listaDeUmADez.add(i);
        }

        ArrayList<Integer> numeroPares = new ArrayList<>();
        ArrayList<Integer> numeroImpares = new ArrayList<>();
        
        for (Integer numero : listaDeUmADez) {
            if (numero % 2 == 0) {
                numeroPares.add(numero);
            } else {
                numeroImpares.add(numero);
            }
        }
        for (Integer numeroPar : numeroPares) {
            System.out.println("Numero Par: " + numeroPar);
        }
        for (Integer numeroImpar : numeroImpares) {
            System.out.println("Numero Impar: " + numeroImpar);
        }
    }
}
