import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {

        Scanner scanner = new Scanner(System.in);

        String adjetivo1;
        String substantivo1;
        String adjetivo2;
        String verbo1;
        String adjetivo3;
        System.out.print("Enter an adjective (description):");
        adjetivo1 = scanner.nextLine();
        System.out.print("Enter a noun (animal or person):");
        substantivo1 = scanner.nextLine();
        System.out.print("Enter an adjective (description):");
        adjetivo2 = scanner.nextLine();
        System.out.print("Enter a verb and with ing (action):");
        verbo1 = scanner.nextLine();
        System.out.print("Enter an adjective (desscription):");
        adjetivo3 = scanner.nextLine();

        System.out.println("Today I went to a " + adjetivo1 + " zoo");
        System.out.println("In an exhibit, I saw a " + substantivo1 + ".");
        System.out.println(substantivo1 + " was " + adjetivo2 + " and " + verbo1 + "!");
        System.out.println("I was " + adjetivo3 + "!");

        scanner.close();
    }
}
