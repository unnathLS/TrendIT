import java.text.DecimalFormat;
import java.util.Scanner;

public class PDV {
    public static void main(String[] args){
        //Variavel
       double total, desconto, totalDesconto, valorPago, troco;
       //ojetos
        Scanner teclado = new Scanner(System.in);
        DecimalFormat formatador = new DecimalFormat("#0.00");
        //Entrada 1
        System.out.print("Digite o valor total da compra: R$ ");
        total = teclado.nextDouble();
        System.out.print("Digite o desconto em porcentagem: " );
        desconto = teclado.nextDouble();
        //Processamento
        totalDesconto = total - (total * desconto) / 100;
        System.out.print("Valor do Desconto: R$ " + formatador.format(totalDesconto));
        System.out.println("");
        //Entrada2
        System.out.print("Digite o valor pago: R$ ");
        valorPago = teclado.nextDouble();
        troco = valorPago - totalDesconto;
        System.out.print("Troco: R$ " + formatador.format(troco));
        teclado.close();

    }
}
