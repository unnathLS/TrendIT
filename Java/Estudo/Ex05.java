public class Ex05 {
    public static void main(String[] args) {
        System.out.println("Estrutura de repetição");
        System.out.println(" ");
        System.out.println("Exemplo 1 - For");
        System.out.println(" ");
        System.out.println("Contando de 1 a 10");
        System.out.println(" ");
        for(int i = 1; i < 10; i++){
            System.out.println(i);
        }
        System.out.println(" ");
        System.out.println("Contando de 10 a 1");
        System.out.println(" ");
        for(int j = 10; j > 0; j--){
            System.out.println(j);
        }
        System.out.println(" ");
        System.out.println("Exemplo 2 - Tabuada");
        System.out.println(" ");
        for(int tabu = 0; tabu <= 10; tabu++){
            System.out.println("Tabuada do " + tabu);
            System.out.println(" ");
            for(int valor = 0; valor <= 10; valor++){
                System.out.println(tabu + " x " + valor + " = " + (tabu * valor));
                System.out.println(" ");
            }
        }
        System.out.println(" ");
        System.out.println("Exemplo 3 - While");
        System.out.println(" ");
        System.out.println("Contando de 1 a 10");
        System.out.println(" ");
        int numero = 1;
        while (numero <= 10){
            System.out.println(numero);
            numero++;
        }
        System.out.println(" ");
        System.out.println("Contando de 10 a 1");
        System.out.println(" ");
        int numero1 = 10;
        while (numero1 >= 1){
            System.err.println(numero1);
            numero1--;
        }
    }
}
