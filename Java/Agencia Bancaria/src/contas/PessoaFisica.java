package contas;

public class PessoaFisica  {
    public static void main(String[] args) {
        Conta cc1 = new Conta();
        cc1.setCliente("João");
        cc1.setSaldo(10000);
        System.out.println("Cliente: " + cc1.getCliente());
        cc1.exibirSaldo();
        cc1.depositar(3500.0);
        cc1.imprimirExtrato();
        System.out.print("--------------------\n");
        Conta cc2 = new Conta();
        cc2.setCliente("Maria");
        cc2.setSaldo(50000);
        System.out.print("--------------------\n");
        System.out.println("Cliente: " + cc2.getCliente());
        cc2.exibirSaldo();
        cc2.sacar(1685);
        cc2.imprimirExtrato();
        System.out.print("--------------------\n");
        System.out.println("Transferência");
        System.out.println("Cliente: " + cc2.getCliente());
        System.out.println("Favorecido: " + cc1.getCliente());
        cc2.transferir(cc1, 46000);
        System.out.print("--------------------\n");
        System.out.println("Extrato");
        System.out.println("Cliente: " + cc1.getCliente());
        cc1.imprimirExtrato();
        System.out.println("Cliente: " + cc2.getCliente());
        cc2.imprimirExtrato();
        System.out.print("--------------------\n");
        System.out.println("Relatório gerencial");
        Conta gerente = new Conta();
        double relatorio = gerente.soma(cc1.getSaldo(), cc2.getSaldo());
        System.out.println("Saldo total nas contas: R$ " + relatorio);
    }
}
