using System;
using System.Windows.Forms;
using TrabalhandoComClasses;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Banco banco = new Banco();
        Conta conta = new ContaCorrente();
        ContaPouopanca cp = new ContaPouopanca();
        GerenciadorDeImposto gi = new GerenciadorDeImposto();
        SeguroDeVida sv = new SeguroDeVida();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            conta.Titular = new Cliente("Victor");
            conta.Titular.idade = 19;
            conta.deposita(250.0);
            conta.Numero = 1;
            conta.transfere(100, cp);
            cp.Titular = new Cliente("Cezar");
            cp.Titular.idade = 19;
            cp.deposita(250.0);
            cp.Numero = 2;

            banco.adicionaConta(conta);
            banco.adicionaConta(cp);

            foreach (Conta c in banco.Contas)
            {
                if (c != null)
                {
                    comboTitulares.Items.Add(c.Titular.Nome);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conta conta = buscaConta();
            
            try
            {
                var valor = Convert.ToDouble(textoValorParaDeposito.Text);
                conta.deposita(valor);
                MessageBox.Show("Saldo Anterior: " + (conta.Saldo - valor) + "\n"
                            + "Saldo Atual: " + conta.Saldo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoValorParaDeposito.Text = "";
        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var conta = buscaConta();

            double valor = Convert.ToDouble(textoValorSaque.Text);

            try
            {
                conta.saca(valor);
                MessageBox.Show("Saldo Anterior: " + (conta.Saldo + valor) + "\n"
                            + "Saldo Atual: " + conta.Saldo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoValorSaque.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TotalizadorDeContas totalizador =  new TotalizadorDeContas();
            foreach (Conta c in banco.Contas)
            {
                if (c != null)
                {
                    totalizador.adiciona(c);
                }
            }
            MessageBox.Show(Convert.ToString(totalizador.saldoTotal));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var conta = buscaConta();
            MessageBox.Show("Conta Número: " + conta.Numero + "\n"
                                + "Saldo: " + conta.Numero);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDestinatario.Items.Clear();

            var conta = buscaConta();

            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoTitular.Text = conta.Titular.Nome;

            foreach (Conta c in banco.Contas)
            {
                if (c != null)
                {
                    comboDestinatario.Items.Add(c.Titular.Nome);
                }
            }
            comboDestinatario.SelectedIndex = 0;

        }

        private Conta buscaConta()
        {
            var index = comboTitulares.SelectedIndex;
            return this.banco.Contas[index];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var conta = buscaConta();
            var index = comboDestinatario.SelectedIndex;
            var destino = banco.Contas[index];
            if (destino != null && textoValorTransferencia.Text != "")
            {
                double valor = Convert.ToDouble(textoValorTransferencia.Text);
                try
                {
                    conta.transfere(valor, destino);
                    MessageBox.Show("Transferência realizada com sucesso!");
                    textoValorTransferencia.Text = "";
                    MessageBox.Show("Saldo atual: " + Convert.ToString(conta.Saldo));
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Você deve selecionar uma conta e um valor válido para realizar a transferência");
            }
            string saldoAtual = Convert.ToString(conta.Saldo);
            textoSaldo.Text = saldoAtual;
            textoSaldo.Update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gi.Adiciona(sv);
            gi.Adiciona(cp);
            MessageBox.Show(Convert.ToString(gi.Total));
        }
    }
}
