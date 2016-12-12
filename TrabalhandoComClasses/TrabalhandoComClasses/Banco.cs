using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComClasses
{
    class Banco
    {
        public Conta[] Contas { get; private set; } = new Conta[10];
        public int Quantidade { private set; get; }
        public void adicionaConta(Conta conta)
        {
            Contas[Quantidade] = conta;
            Quantidade++;
        }
    }
}
