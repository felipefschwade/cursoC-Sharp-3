using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComClasses
{
    class ContaCorrente : Conta
    {
        public override void saca(double valorASacar)
        {
            if (valorASacar > 0 && valorASacar <= this.Saldo)
            {
                this.Saldo -= valorASacar;
            }
            else
            {
                throw new System.InvalidOperationException("Você não possui saldo para este saque");
            }
        }
    }
}
