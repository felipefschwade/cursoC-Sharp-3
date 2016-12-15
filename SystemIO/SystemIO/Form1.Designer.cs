namespace SystemIO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.texto = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.botaoEscrever = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(12, 12);
            this.texto.Multiline = true;
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(260, 165);
            this.texto.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // botaoEscrever
            // 
            this.botaoEscrever.Location = new System.Drawing.Point(77, 183);
            this.botaoEscrever.Name = "botaoEscrever";
            this.botaoEscrever.Size = new System.Drawing.Size(138, 23);
            this.botaoEscrever.TabIndex = 1;
            this.botaoEscrever.Text = "Escrever";
            this.botaoEscrever.UseVisualStyleBackColor = true;
            this.botaoEscrever.Click += new System.EventHandler(this.botaoEscrever_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.botaoEscrever);
            this.Controls.Add(this.texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button botaoEscrever;
    }
}

