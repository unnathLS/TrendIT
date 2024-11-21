package carros;

public class Cessna {
public static void main(String[] args) {
    Aviao cessna = new Aviao();
    cessna.ano = 2000;
    cessna.cor = "Vermelho";
    System.out.println("Aviao: Cessna");
    System.out.println("Ano: " + cessna.ano);
    System.out.println("Cor: " + cessna.cor);
    cessna.aterrizar();
    cessna.desligar();
}
}
