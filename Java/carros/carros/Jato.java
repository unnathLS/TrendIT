package carros;

public class Jato {
    public static void main(String[] args) {
        Aviao jato = new Aviao();
        jato.ano = 2024;
        jato.cor = "Cinza";
        System.out.println("Aviao: Jato");
        System.out.println("Ano: " + jato.ano);
        System.out.println("Cor: " + jato.cor);
        jato.ligar();
        jato.acelerar();
    }
}

