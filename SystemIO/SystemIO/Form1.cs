using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (Stream entrada = File.Open("D:/Documents/Alura/C#III/codigos/SystemIO/texto.txt", FileMode.Open))
            using (StreamReader streamReader = new StreamReader(entrada))
            {
                texto.Text = streamReader.ReadToEnd();
            }
        }

        private void botaoEscrever_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("D:/Documents/Alura/C#III/codigos/SystemIO/texto.txt", FileMode.Create))
            using (StreamWriter streamWriter = new StreamWriter(saida))
            {
                streamWriter.Write(texto.Text);
            }

        }
    }
}
