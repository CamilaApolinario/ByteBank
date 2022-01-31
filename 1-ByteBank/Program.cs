using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente(865, 865123);
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
            Console.WriteLine("ByteBanK possui " + ContaCorrente.TotaldeContas + " contas.");

            Console.ReadLine();
        }
    }
}
