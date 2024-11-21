package carros;

public class Ferrari {
    public static void main(String[] args) {
        Carro ferrari = new Carro();
        ferrari.cor = "Vermelho";
        ferrari.ano = 2022;
        System.out.println("Carro: Ferrari");
        System.out.println("Ano: " + ferrari.ano);
        System.out.println("Cor: " + ferrari.cor);
        ferrari.ligar();
        ferrari.acelerar();
    }
}