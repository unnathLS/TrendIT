import java.text.DecimalFormat;
import java.util.Scanner;
public class Porcentagem {
    public static void main(String[] args) {
        double x , y, valor ;
        Scanner teclado = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("#0.00");
        DecimalFormat df1 = new DecimalFormat("#0");
        System.out.println("Conversor de Porcentagem");
        System.out.print("Digite o x valor: ");
        x = teclado.nextDouble();
        System.out.print("Digite o y valor: ");
        y = teclado.nextDouble();
        valor = (x * y) / 100;

        System.out.println(df1.format(x) + " % de " + df1.format(y)+ " = " + df.format(valor));
        teclado.close();
        
        

    }
}
