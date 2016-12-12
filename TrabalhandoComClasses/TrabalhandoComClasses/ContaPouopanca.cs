using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComClasses
{
    class ContaPouopanca : Conta, ITributavel
    {
        public double calculaTributos()
        {
            return Saldo * 0.02;
        }

        public override void saca(double valorASacar)
        {
            if (valorASacar > 0 && valorASacar <= this.Saldo)
            {
                this.Saldo -= valorASacar + 0.1;
            }
            else
            {
                throw new System.InvalidOperationException("Você não possui saldo para este saque");
            }
        }
    }
}
