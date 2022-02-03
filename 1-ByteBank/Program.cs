using _1_ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*ContaCorrente primeiraContaCorrente = new ContaCorrente(865, 865123);
            ContaCorrente segundaContaCorrente = new ContaCorrente(865, 865321);

            primeiraContaCorrente.Depositar(200);
            Console.WriteLine("Depósito realizado na primeiraConta, saldo atual R$ " + primeiraContaCorrente.Saldo);

            primeiraContaCorrente.Sacar(100);
            Console.WriteLine("Saque realizado na primeiraConta, saldo atual R$ " + primeiraContaCorrente.Saldo);

            primeiraContaCorrente.Transferir(50, segundaContaCorrente);
            Console.WriteLine("Você transferiu, para segunda conta seu saldo atual R$ " + primeiraContaCorrente.Saldo);
            Console.WriteLine();
            
            Console.WriteLine("ByteBanK possui " + ContaCorrente.TotaldeContas + " contas.");
            Console.WriteLine();

            segundaContaCorrente.Depositar(100);
            Console.WriteLine("Depósito realizado na segundaConta, saldo atual R$ " + segundaContaCorrente.Saldo);

            segundaContaCorrente.Sacar(50);
            Console.WriteLine("Saque realizado na segundaConta, saldo atual R$ " + segundaContaCorrente.Saldo);
  
            segundaContaCorrente.Transferir(100, primeiraContaCorrente);
            Console.WriteLine("Você transferiu, para primeiraConta seu saldo atual R$ " + segundaContaCorrente.Saldo);
            
            Console.WriteLine();
            Console.WriteLine("ByteBanK possui " + ContaCorrente.TotaldeContas + " contas.");
            Console.WriteLine();

            ContaCorrente contaCamila = new ContaCorrente(865, 865234);
            contaCamila.Titular = new Cliente();

            contaCamila.Titular.Nome = "Camila";
            Console.WriteLine(contaCamila.Titular.Nome);
            Console.WriteLine("ByteBanK possui " + ContaCorrente.TotaldeContas + " contas.");*/

            CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();
            

        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());

           
        }

    }
       
        
}

