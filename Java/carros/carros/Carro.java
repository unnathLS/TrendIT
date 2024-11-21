package carros;

import java.util.Random;

public class Carro {
    int ano;
    String cor;
    public Carro() {
        Random gerador =new Random();
         int chassi = gerador.nextInt(1000 , 9999);
        System.out.println("Chassis: " + chassi);
    }
    public Carro(int ano, String cor) {
       this.ano = ano;
       this.cor = cor; 
    }
    void ligar(){
        System.out.println("Engine On  ***** ");
    }
    void desligar(){
        System.out.println("Engine Off");
    }
    void acelerar(){
        System.out.println("Vruuuuuuuuuummmmmmmmmmm!");
    }
}
