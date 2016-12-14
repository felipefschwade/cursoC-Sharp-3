using Empresa.CaixaEletronico.Usuarios;
using System;

namespace Empresa.CaixaEletronico.Contas
{
    public abstract class Conta : IComparable
    {
        public Cliente Titular { get; set; } 
        public double Saldo { get; protected set; }
        public int Numero { get; protected set; }
        public int Agencia { get; set; }

        public abstract void saca(double valorASacar);
        public void deposita(double valorADepositar)
        {
            if (valorADepositar > 0)
            {
                this.Saldo += valorADepositar;
            }
        }
           
        public void transfere(double valorATransferir, Conta destino)
        {
            if (destino.Equals(this))
            {
                throw new InvalidOperationException("Você não pode realizar uma transferência para você mesmo");
            }
            this.saca(valorATransferir);
            Console.WriteLine(this.Saldo);
            destino.deposita(valorATransferir);
            Console.WriteLine(this.Saldo);
        }

        public int CompareTo(object obj)
        {
            Conta c = (Conta)obj;
            if (Numero < c.Numero) return -1;
            if (Numero == c.Numero) return 0;
            return 1;
        }
    }
}