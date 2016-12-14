﻿using System;
using System.Windows.Forms;
using Empresa.CaixaEletronico;
using Empresa.CaixaEletronico.Contas;
using Empresa.CaixaEletronico.Usuarios;
using Empresa.CaixaEletronico.Servicos;

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

        public void AdicionaConta(Conta conta)
        {
            banco.adicionaConta(conta);
            comboTitulares.Items.Add(conta);
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            conta.Titular = new Cliente("Victor");
            conta.Titular.idade = 19;
            conta.deposita(250.0);
            conta.transfere(100, cp);
            cp.Titular = new Cliente("Cezar");
            cp.Titular.idade = 19;
            cp.deposita(250.0);
            
            banco.adicionaConta(conta);
            banco.adicionaConta(cp);

            foreach (Conta c in banco.Contas)
            {
                if (c != null)
                {
                    comboTitulares.Items.Add(c);
                }
            }
            comboTitulares.DisplayMember = "titular";
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
            MessageBox.Show("Conta Número: " + Conta.Numero + "\n"
                                + "Saldo: " + Conta.Numero);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDestinatario.Items.Clear();

            var conta = buscaConta();

            textoNumero.Text = Convert.ToString(Conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoTitular.Text = conta.Titular.Nome;

            foreach (Conta c in banco.Contas)
            {
                if (c != null)
                {
                    if (!c.Equals(conta))
                    {
                        comboDestinatario.Items.Add(c);
                    }
                }
            }
            comboDestinatario.SelectedIndex = 0;
            comboDestinatario.DisplayMember = "titular";

        }

        private Conta buscaConta()
        {
            return (Conta)comboTitulares.SelectedItem;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var conta = buscaConta();
            var destino = (Conta)comboDestinatario.SelectedItem;
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

        private void button7_Click(object sender, EventArgs e)
        {
            CadastroDeConta cad = new CadastroDeConta(this);
            cad.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var conta = buscaConta();
            try
            {
                comboTitulares.Items.Remove(conta);
                comboTitulares.Items.Clear();
                comboTitulares.SelectedIndex = -1;
                banco.RemoveConta(conta);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            foreach (Conta c in banco.Contas)
            {
                if (c != null)
                {
                    comboTitulares.Items.Add(c);
                }
            }
            textoNumero.Text = "";
            textoTitular.Text = "";
            textoSaldo.Text = "";

            
        }
    }
}
