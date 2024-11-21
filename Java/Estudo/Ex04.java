
public class Ex04 {
    public static void main(String[] args) {
        String nome = "Luiz Henrique";
        int idade = 18;
        char sexo = 'M';
        System.out.println(nome);
        System.out.println("Estrutura de controle condicional");
        System.out.println("Exemplo 1 - Uso do if");
        System.out.println("");
        if (sexo == 'M'){
            System.out.println("Alistamento militar obrigatório");
        }
        System.out.println("");
        System.out.println("Exemplo 2- Uso do 'if - else'");
        System.out.println("");
        if (idade > 18){
            System.out.println("Maior de idade");
        }else{
            System.out.println("Menor de idade");
        }
        System.out.println("");
        System.out.println("Exemplo 3 - Uso do 'if - else if - else'");
        System.out.println("");
        if (idade > 18){
            System.out.println("Maior de idade");
        }else if (idade == 18){
            System.out.println("Tem 18 anos");
        }else{
            System.out.println("Menor de idade");
        }
        System.out.println("");
        System.out.println("Exemplo 4 - Uso do 'switch'");
        System.out.println("");
        switch (nome) {
            case "Luiz Henrique":
                System.out.println("Olá, Luiz Henrique ");
                break;
        
            default:
                System.out.println("Olá, desconhecido");
                break;
        }
    }
}
