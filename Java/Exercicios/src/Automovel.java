import java.text.DecimalFormat;
import java.util.Scanner;

public class Automovel {
    public static void main(String[] args) {
        //Variavel
        double gasolina, etanol,valor;

        //Objeto
        Scanner teclado = new Scanner(System.in);

        //Entrada
        System.out.print("Digite o valor da etanol: R$ ");
        gasolina = teclado.nextDouble();
        System.out.print("Digite o valor do gasolina: R$ ");
        etanol = teclado.nextDouble();

        //Processamento
        valor = (gasolina * etanol) / 100;

        //Saida
        if (valor >= 70){
            System.out.println("Abastecer com Etanol");
        }else{
            System.out.println("Abastecer com Gasolina");
        }
        teclado.close();
    }
}
