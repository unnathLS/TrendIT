import java.text.DecimalFormat;
import java.util.Scanner;

public class Imc {
    public static void main(String[] args) {
        //Variavel
        double peso, altura, imc;

        //Objeto
        Scanner teclado = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("#0.0");

        //Entrada
        System.out.print("Seu peso : ");
        peso = teclado.nextDouble();
        System.out.print("Sua Altura em metros: ");
        altura = teclado.nextDouble();

        //Processamento
        imc = peso / (altura * altura);

        //Saida
        System.out.print(("Seu IMC: " + df.format(imc) + " - " + getImc(imc)));
    }

    public static String getImc(double imc){
        String imcClassficacao = "";

        if (imc < 18.5){
            imcClassficacao = "Abaixo do Peso";
        }else if (imc >= 18.5 && imc <= 24.9){
            imcClassficacao = "Peso Normal";
        }else if (imc >= 25 && imc <= 29.9){
            imcClassficacao = "Sobrepeso";
        }else if (imc >= 30 && imc <= 34.9){
            imcClassficacao = "Obesidade Grau I";
        }else if (imc >= 35 && imc <= 39.9){
            imcClassficacao = "Obesidade Grau II";
        }else if (imc >= 40){
            imcClassficacao = "Obesidade Grau III";
        }

        return imcClassficacao;
    }

}
