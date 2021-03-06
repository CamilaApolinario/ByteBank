using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;
        public static int TotalDeContasCriadas { get; private set; }
        private static int TaxaOperacao { get; set; }


        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }            
                _saldo = value;                   
            }
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor de saque não podde ser negativo", nameof(valor));
            }
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(_saldo, valor);
            }

            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;

        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                throw new ArgumentException("valor inválido para transferencia ", nameof(valor));
            }
            Sacar(valor);
            contaDestino.Depositar(valor);
            
        }

    }

    
}
