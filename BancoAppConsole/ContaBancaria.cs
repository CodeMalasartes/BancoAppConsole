using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BancoAppConsole
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;          
        }
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;

        }
        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }
        public void Levantamento(double quantia)
        {
            Saldo -= quantia + 5.0;  // 5 de taxa de levantamento
        }
        public override string ToString()
        {
            return "Conta " 
                + Numero
                +", Titular:"
                + Titular
                +", Saldo:$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }   
}
