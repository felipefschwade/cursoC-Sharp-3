using Empresa.CaixaEletronico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CaixaEletronico.Contas
{
    class SeguroDeVida : ITributavel
    {
        public double calculaTributos()
        {
            return 42;
        }
    }
}
