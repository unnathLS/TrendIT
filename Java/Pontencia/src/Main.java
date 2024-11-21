import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
   public static void main(String[] args) {
      double x , y, valor;
       Scanner teclado = new Scanner(System.in);
       System.out.println("Calculadora de porcentagem");
       System.out.print("Digite o valor a ser calculado: ");
       x = teclado.nextInt();
       System.out.print("Digite a porcentagem: ");
       System.out.print("\n");
       y = teclado.nextInt();
       System.out.println("Resultado:");
       valor = x * y / 100;
       System.out.println(y + "% de " + x + " = " + valor);
   }
}