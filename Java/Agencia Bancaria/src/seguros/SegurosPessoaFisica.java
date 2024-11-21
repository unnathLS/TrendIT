package seguros;

import contas.Conta;

public class SegurosPessoaFisica extends Conta{
    public static void main(String[] args) {
        SegurosPessoaFisica cc3 = new SegurosPessoaFisica();
        cc3.setCliente("Antonio");
        cc3.setSaldo(8000);
        System.out.println("Cliente: " + cc3.getCliente());
        cc3.exibirSaldo();
    }
}
