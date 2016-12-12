using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CaixaEletronico.Contas
{
    class ContaCorrente : Conta
    {
        public override void saca(double valorASacar)
        {
            if (valorASacar > 0 && valorASacar <= this.Saldo + 0.1)
            {
                this.Saldo -= valorASacar;
            }
            else
            {
                throw new System.InvalidOperationException("Você não possui saldo para esta operação");
            }
        }
    }
}
