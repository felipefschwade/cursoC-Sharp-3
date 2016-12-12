using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.CaixaEletronico.Contas;

namespace Empresa.CaixaEletronico.Servicos
{
    class TotalizadorDeContas
    {
        public double saldoTotal { get; private set; }

        public void adiciona(Conta conta)
        {
            this.saldoTotal += conta.Saldo;
        }
    }
}
