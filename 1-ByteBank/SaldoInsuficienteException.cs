using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; set; }

        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this("Tentativa de saque de " + valorSaque + "com o saldo insuficiente de "+ saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException()
        {
        }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
