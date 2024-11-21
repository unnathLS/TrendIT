package carros;

public class Jetta {
    public static void main(String[] args) {
        Carro jetta = new Carro();
        jetta.cor = "Preto";
        jetta.ano = 2023;
        System.out.println("Carro: Jetta");
        System.out.println("Ano: " + jetta.ano);
        System.out.println("Cor: " + jetta.cor);
        jetta.ligar();
        jetta.acelerar();
    }
}
