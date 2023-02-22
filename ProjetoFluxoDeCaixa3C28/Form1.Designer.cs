namespace ProjetoFluxoDeCaixa3C28
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnlancamentos = new System.Windows.Forms.Button();
            this.btncontas = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnsaldo = new System.Windows.Forms.Button();
            this.btnlancamentoss = new System.Windows.Forms.Button();
            this.btnconsultaconta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatorioPorLancamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlancamentos
            // 
            this.btnlancamentos.Location = new System.Drawing.Point(25, 153);
            this.btnlancamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlancamentos.Name = "btnlancamentos";
            this.btnlancamentos.Size = new System.Drawing.Size(139, 64);
            this.btnlancamentos.TabIndex = 2;
            this.btnlancamentos.Text = "Lançamentos";
            this.btnlancamentos.UseVisualStyleBackColor = true;
            this.btnlancamentos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncontas
            // 
            this.btncontas.Location = new System.Drawing.Point(25, 67);
            this.btncontas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncontas.Name = "btncontas";
            this.btncontas.Size = new System.Drawing.Size(139, 64);
            this.btncontas.TabIndex = 3;
            this.btncontas.Text = "Contas";
            this.btncontas.UseVisualStyleBackColor = true;
            this.btncontas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(201, 153);
            this.btnsair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(139, 64);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnsaldo
            // 
            this.btnsaldo.Location = new System.Drawing.Point(201, 67);
            this.btnsaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaldo.Name = "btnsaldo";
            this.btnsaldo.Size = new System.Drawing.Size(139, 64);
            this.btnsaldo.TabIndex = 6;
            this.btnsaldo.Text = "Saldo";
            this.btnsaldo.UseVisualStyleBackColor = true;
            this.btnsaldo.Click += new System.EventHandler(this.btnsaldo_Click);
            // 
            // btnlancamentoss
            // 
            this.btnlancamentoss.Location = new System.Drawing.Point(25, 236);
            this.btnlancamentoss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlancamentoss.Name = "btnlancamentoss";
            this.btnlancamentoss.Size = new System.Drawing.Size(139, 64);
            this.btnlancamentoss.TabIndex = 7;
            this.btnlancamentoss.Text = "ENTRADA\r\nSAÌDA";
            this.btnlancamentoss.UseVisualStyleBackColor = true;
            this.btnlancamentoss.Click += new System.EventHandler(this.btnlancamentoss_Click);
            // 
            // btnconsultaconta
            // 
            this.btnconsultaconta.Location = new System.Drawing.Point(201, 236);
            this.btnconsultaconta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnconsultaconta.Name = "btnconsultaconta";
            this.btnconsultaconta.Size = new System.Drawing.Size(139, 64);
            this.btnconsultaconta.TabIndex = 8;
            this.btnconsultaconta.Text = "CONSULTA\r\nCONTA";
            this.btnconsultaconta.UseVisualStyleBackColor = true;
            this.btnconsultaconta.Click += new System.EventHandler(this.btnconsultaconta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioPorLancamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatorioPorLancamentoToolStripMenuItem
            // 
            this.relatorioPorLancamentoToolStripMenuItem.Name = "relatorioPorLancamentoToolStripMenuItem";
            this.relatorioPorLancamentoToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.relatorioPorLancamentoToolStripMenuItem.Text = "Relatorio Por Lancamento";
            this.relatorioPorLancamentoToolStripMenuItem.Click += new System.EventHandler(this.relatorioPorLancamentoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 357);
            this.Controls.Add(this.btnconsultaconta);
            this.Controls.Add(this.btnlancamentoss);
            this.Controls.Add(this.btnsaldo);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncontas);
            this.Controls.Add(this.btnlancamentos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlancamentos;
        private System.Windows.Forms.Button btncontas;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnsaldo;
        private System.Windows.Forms.Button btnlancamentoss;
        private System.Windows.Forms.Button btnconsultaconta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatorioPorLancamentoToolStripMenuItem;
    }
}

