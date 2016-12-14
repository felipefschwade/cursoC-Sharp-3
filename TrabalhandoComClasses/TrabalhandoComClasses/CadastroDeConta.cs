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
            comboTipoConta.Items.Add("Conta Corrente");
            comboTipoConta.Items.Add("Conta Poupança");
            comboTipoConta.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente(textoNome.Text);
            cliente.rg = textoRg.Text;
            var tipoConta = comboTipoConta.SelectedItem;
            
            try
            {
                if (tipoConta.Equals("Conta Corrente"))
                {
                    var conta = new ContaCorrente()
                    {
                        Titular = cliente
                    };
                    aplicacaoPrincipal.AdicionaConta(conta);
                }
                else if (tipoConta.Equals("Conta Poupança"))
                {
                    var conta = new ContaPoupanca()
                    {
                        Titular = cliente
                    };
                    aplicacaoPrincipal.AdicionaConta(conta);
                }
                MessageBox.Show("Conta cadastrada com sucesso!");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
    }
}
