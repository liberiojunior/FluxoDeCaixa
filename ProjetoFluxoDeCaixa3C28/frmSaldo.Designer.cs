namespace ProjetoFluxoDeCaixa3C28
{
    partial class frmSaldo
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
            this.dtgsaldo = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.gfrs = new System.Windows.Forms.Panel();
            this.txtsaldoperiodo = new System.Windows.Forms.TextBox();
            this.lblsaldoperiodo = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.lblde = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsaldogeral = new System.Windows.Forms.TextBox();
            this.lblsaldogeral = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsaldo)).BeginInit();
            this.gfrs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgsaldo
            // 
            this.dtgsaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsaldo.Location = new System.Drawing.Point(5, 114);
            this.dtgsaldo.Name = "dtgsaldo";
            this.dtgsaldo.Size = new System.Drawing.Size(466, 159);
            this.dtgsaldo.TabIndex = 2;
            this.dtgsaldo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(267, 11);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 39);
            this.btnpesquisar.TabIndex = 4;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // gfrs
            // 
            this.gfrs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gfrs.Controls.Add(this.txtsaldoperiodo);
            this.gfrs.Controls.Add(this.lblsaldoperiodo);
            this.gfrs.Controls.Add(this.lbla);
            this.gfrs.Controls.Add(this.dtpInicial);
            this.gfrs.Controls.Add(this.dtpFinal);
            this.gfrs.Controls.Add(this.lblde);
            this.gfrs.Location = new System.Drawing.Point(1, 12);
            this.gfrs.Name = "gfrs";
            this.gfrs.Size = new System.Drawing.Size(260, 96);
            this.gfrs.TabIndex = 5;
            // 
            // txtsaldoperiodo
            // 
            this.txtsaldoperiodo.Enabled = false;
            this.txtsaldoperiodo.Location = new System.Drawing.Point(124, 42);
            this.txtsaldoperiodo.Multiline = true;
            this.txtsaldoperiodo.Name = "txtsaldoperiodo";
            this.txtsaldoperiodo.Size = new System.Drawing.Size(100, 29);
            this.txtsaldoperiodo.TabIndex = 2;
            // 
            // lblsaldoperiodo
            // 
            this.lblsaldoperiodo.AutoSize = true;
            this.lblsaldoperiodo.Location = new System.Drawing.Point(9, 49);
            this.lblsaldoperiodo.Name = "lblsaldoperiodo";
            this.lblsaldoperiodo.Size = new System.Drawing.Size(93, 13);
            this.lblsaldoperiodo.TabIndex = 7;
            this.lblsaldoperiodo.Text = "Saldo no Período:";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(124, 8);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(13, 13);
            this.lbla.TabIndex = 6;
            this.lbla.Text = "a";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(30, 5);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(80, 20);
            this.dtpInicial.TabIndex = 9;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(148, 4);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpFinal.TabIndex = 8;
            // 
            // lblde
            // 
            this.lblde.AutoSize = true;
            this.lblde.Location = new System.Drawing.Point(3, 7);
            this.lblde.Name = "lblde";
            this.lblde.Size = new System.Drawing.Size(21, 13);
            this.lblde.TabIndex = 7;
            this.lblde.Text = "De";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtsaldogeral);
            this.panel1.Controls.Add(this.lblsaldogeral);
            this.panel1.Location = new System.Drawing.Point(345, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 96);
            this.panel1.TabIndex = 6;
            // 
            // txtsaldogeral
            // 
            this.txtsaldogeral.Enabled = false;
            this.txtsaldogeral.Location = new System.Drawing.Point(7, 49);
            this.txtsaldogeral.Multiline = true;
            this.txtsaldogeral.Name = "txtsaldogeral";
            this.txtsaldogeral.Size = new System.Drawing.Size(100, 29);
            this.txtsaldogeral.TabIndex = 1;
            // 
            // lblsaldogeral
            // 
            this.lblsaldogeral.AutoSize = true;
            this.lblsaldogeral.Location = new System.Drawing.Point(13, 11);
            this.lblsaldogeral.Name = "lblsaldogeral";
            this.lblsaldogeral.Size = new System.Drawing.Size(65, 13);
            this.lblsaldogeral.TabIndex = 0;
            this.lblsaldogeral.Text = "Saldo Geral:";
            // 
            // frmSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gfrs);
            this.Controls.Add(this.dtgsaldo);
            this.Controls.Add(this.btnpesquisar);
            this.Name = "frmSaldo";
            this.Text = "frmSaldo";
            this.Load += new System.EventHandler(this.frmSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgsaldo)).EndInit();
            this.gfrs.ResumeLayout(false);
            this.gfrs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DataGridView dtgsaldo;
        private System.Windows.Forms.Panel gfrs;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblde;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label lblsaldoperiodo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsaldoperiodo;
        private System.Windows.Forms.TextBox txtsaldogeral;
        private System.Windows.Forms.Label lblsaldogeral;
    }
}