import java.text.DecimalFormat;
import java.util.Scanner;

public class CargaHoraria {
    public static void main(String[] args) {
        //Variavel
        double hora, remuneracao,custo,cargaHoraria;
        //Objeto
        Scanner teclado = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("#0.00");
        //Entradas
        System.out.print("Remuneração mensal: R$ ");
        remuneracao = teclado.nextDouble();
        System.out.print("Custo operacional mensal: R$ ");
        custo = teclado.nextDouble();
        System.out.print("Horas trabalhadas: ");
        cargaHoraria = teclado.nextDouble();
        //Processamento
        hora = (remuneracao + ( remuneracao * 0.3) + custo + (remuneracao * 0.2)) / cargaHoraria;
        System.out.println("Carga Horaria: " + df.format(hora));
        teclado.close();

    }
}
