package org.unnath.logica;

import java.util.ArrayList;

public class EstruturaDeRepeticao {
    public static void main(String[] args) {
        listaDePalavras();
        forClassico();
        forPuro();
        inverter();

    }

    private static void listaDePalavras() {
        ArrayList<String> palavraList = new ArrayList<>();
        palavraList.add("Java");
        palavraList.add("Python");
        palavraList.add("C++");
        palavraList.add("C#");
        System.out.println("----------------------------------------------------");
        // Programação estruturada
        for (String palavra : palavraList) {
            System.out.println(palavra);
        }
        System.out.println("----------------------------------------------------");
        // Programação funcional
        palavraList.forEach(palavra -> System.out.println(palavra));
    }

    private static void forClassico() {
        ArrayList<String> palavraList = new ArrayList<>();
        palavraList.add("Java");
        palavraList.add("Python");
        palavraList.add("C++");
        palavraList.add("C#");
        for (int i = 0; i < palavraList.size(); i++) {
            System.out.println(palavraList.get(i));
        }
    }

    private static void forPuro() {
        for (int i = 0; i <= 10; i++) {
            System.out.println(i + " ");
        }
    }
    private static void inverter() {
        String normal = "12345";
        String invertida = "";
        for (int i = normal.length() - 1; i >= 0 ; i--) {
            invertida = invertida + normal.charAt(i);
        }
        System.out.println(invertida);
        
    }
}
