using Empresa.CaixaEletronico.Contas;
using Empresa.CaixaEletronico.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Empresa.CaixaEletronico
{
    public partial class CadastroDeConta : Form
    {
        private Form1 aplicacaoPrincipal;

        public CadastroDeConta(Form1 formulario)
        {
            this.aplicacaoPrincipal = formulario;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente(textoNome.Text);
            cliente.rg = textoRg.Text;
            var conta = new ContaCorrente() {
                Titular = cliente
            };
            aplicacaoPrincipal.AdicionaConta(conta);
            MessageBox.Show("Conta cadastrada com sucesso!");
            this.Close();
        }
    }
}
