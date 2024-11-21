import java.util.Scanner;
import java.text.DecimalFormat;
public class Conversor {
    public static void main(String[] args) {
        double c, f;
        Scanner tcd = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("0.0");
        DecimalFormat df1 = new DecimalFormat("0");
        System.out.println("Conversor de Temperatura");
        System.out.println("Digite a temperatura em Franheit: ");
        f = tcd.nextDouble();
        c = (5 * (f - 32))/9;
        System.out.println("Temperatura em Celsius: " + df.format(c));
        System.out.println("\n");
        System.out.print("Digite a temperatura em Celsius: ");
        c = tcd.nextDouble();
        f  = (c * 9 / 5) + 32;
        System.out.println("Temperatura em Fahrenheit: " + df1.format(f));
    }
}
