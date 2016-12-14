using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.CaixaEletronico.Contas;
using System.Windows.Forms;

namespace Empresa.CaixaEletronico
{
    class Banco
    {
        public SortedSet<Conta> Contas { get; private set; } = new SortedSet<Conta>();
        public int Quantidade { private set; get; }
        public void adicionaConta(Conta conta)
        {
            Contas.Add(conta);
        }

        public void RemoveConta(Conta conta)
        {
            Contas.Remove(conta);   
        }
    }
}
