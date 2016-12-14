using Empresa.CaixaEletronico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Empresa.CaixaEletronico.Contas
{
    class ContaPoupanca : Conta, ITributavel
    {
        public ContaPoupanca()
        {
            Numero++;
            Numero = Numero;
        }

        public double calculaTributos()
        {
            return Saldo * 0.02;
        }

        public override void saca(double valorASacar)
        {
            if (valorASacar > 0 && valorASacar <= (this.Saldo - 0.1))
            {
                this.Saldo -= valorASacar + 0.1;
            }
            else
            {
                throw new System.InvalidOperationException("Você não possui saldo para esta operação");
            }
        }
    }
}
