import java.util.Random;
import java.util.Scanner;

public class JoKenPo {
    public static void main(String[] args) {
        //Variavel
        int escolha,computador;


        //Objeto
        Scanner teclado = new Scanner(System.in);

        //Entrada
        System.out.println("______Jo__Ken__Po______\n");
        System.out.println("1.Pedra");
        System.out.println("2.Papel");
        System.out.println("3.Tesoura");
        System.out.print("Escolha um numero correspondente a sua jogada: ");
        escolha = teclado.nextInt();
        System.out.print("-----------------Escolhas------------------\n");

        //Processamento
        switch (escolha) {
            case 1:
                System.out.println("Voce escolheu Pedra");
                break;
            case 2:
                System.out.println("Voce escolheu Papel");
                break;
            case 3:
                System.out.println("Voce escolheu Tesoura");
                break;
            default:
                System.out.println("Escolha invalida");
        }
        //Logica computador
        computador = (int) (Math.random() * 3) + 1;
        switch (computador) {
            case 1:
                System.out.println("Computador escolheu Pedra");
                break;
            case 2:
                System.out.println("Computador escolheu Papel");
                break;
            case 3: System.out.println("Computador escolheu Tesoura");
                break;
        }
        //Logica do jogo
        System.out.print("-----------------Resultado------------------\n");
        if(escolha == computador){
            System.out.println("Empate");
        }else if(escolha == 1 && computador == 3 || escolha == 2 && computador == 1 || escolha == 3 && computador ==2){
            System.out.println("Voce ganhou");
        }else{
            System.out.println("Voce perdeu");
        }
    }
//    public static String getEscolha(String maquinaEscolha) {
//        String maquinaEscolha = "";
//
//        Random random = new Random();
//
//        int maquina = random.nextInt(3) + 1;
//
//        if (maquina == 1) {
//            maquinaEscolha = "Pedra";
//        } else if (maquina == 2) {
//            maquinaEscolha = "Papel";
//        } else {
//            maquinaEscolha = "Tesoura";
//        }
////        System.out.println(maquinaEscolha);
////        return maquinaEscolha;
//    }
}


