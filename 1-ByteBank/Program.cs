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
            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            ContaCorrente segundaContaCorrente = new ContaCorrente();

            segundaContaCorrente.Depositar(100);
            primeiraContaCorrente.Depositar(200);        

            Console.WriteLine("Depósito realizado na primeiraConta, saldo atual R$ " + primeiraContaCorrente._saldo);
            Console.WriteLine("Depósito realizado na segundaConta, saldo atual R$ " + segundaContaCorrente._saldo);
            Console.WriteLine();

            primeiraContaCorrente.Sacar(100);
            segundaContaCorrente.Sacar(50);

            Console.WriteLine("Saque realizado na primeiraConta, saldo atual R$ " + primeiraContaCorrente._saldo);
            Console.WriteLine("Saque realizado na segundaConta, saldo atual R$ " + segundaContaCorrente._saldo);
            Console.WriteLine();

            primeiraContaCorrente.Transferir(50, segundaContaCorrente);
            Console.WriteLine("Você transferiu, para segunda conta seu saldo atual R$ " + primeiraContaCorrente._saldo);
            Console.WriteLine();

            segundaContaCorrente.Transferir(100, primeiraContaCorrente);
            Console.WriteLine("Você transferiu, para primeiraConta seu saldo atual R$ " + segundaContaCorrente._saldo);
            Console.WriteLine();

            ContaCorrente contaCamila = new ContaCorrente();
            contaCamila.Titular = new Cliente();

            contaCamila.Titular.Nome = "Camila";
            Console.WriteLine(contaCamila.Titular.Nome);

            Console.ReadLine();
        }
    }
}
