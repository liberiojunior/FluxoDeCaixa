namespace ProjetoFluxoDeCaixa3C28
{
    partial class frmLancamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.cmbconta = new System.Windows.Forms.ComboBox();
            this.rdbsaida = new System.Windows.Forms.RadioButton();
            this.rdbentrada = new System.Windows.Forms.RadioButton();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.dtglancamentos = new System.Windows.Forms.DataGridView();
            this.txtdata = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtglancamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(90, 6);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 4;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(90, 30);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(298, 20);
            this.txtdescricao.TabIndex = 5;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(288, 58);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 6;
            // 
            // cmbconta
            // 
            this.cmbconta.FormattingEnabled = true;
            this.cmbconta.Location = new System.Drawing.Point(90, 57);
            this.cmbconta.Name = "cmbconta";
            this.cmbconta.Size = new System.Drawing.Size(121, 21);
            this.cmbconta.TabIndex = 7;
            // 
            // rdbsaida
            // 
            this.rdbsaida.AutoSize = true;
            this.rdbsaida.Location = new System.Drawing.Point(158, 84);
            this.rdbsaida.Name = "rdbsaida";
            this.rdbsaida.Size = new System.Drawing.Size(54, 17);
            this.rdbsaida.TabIndex = 8;
            this.rdbsaida.TabStop = true;
            this.rdbsaida.Text = "Saída";
            this.rdbsaida.UseVisualStyleBackColor = true;
            // 
            // rdbentrada
            // 
            this.rdbentrada.AutoSize = true;
            this.rdbentrada.Location = new System.Drawing.Point(90, 84);
            this.rdbentrada.Name = "rdbentrada";
            this.rdbentrada.Size = new System.Drawing.Size(62, 17);
            this.rdbentrada.TabIndex = 9;
            this.rdbentrada.TabStop = true;
            this.rdbentrada.Text = "Entrada";
            this.rdbentrada.UseVisualStyleBackColor = true;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(251, 65);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(31, 13);
            this.lblvalor.TabIndex = 10;
            this.lblvalor.Text = "Valor";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(251, 88);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(30, 13);
            this.lbldata.TabIndex = 11;
            this.lbldata.Text = "Data";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(299, 127);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(89, 36);
            this.btnsair.TabIndex = 16;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(205, 127);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(89, 36);
            this.btnlimpar.TabIndex = 15;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(112, 127);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(89, 36);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click_1);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(15, 127);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(89, 36);
            this.btngravar.TabIndex = 13;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // dtglancamentos
            // 
            this.dtglancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglancamentos.Location = new System.Drawing.Point(12, 180);
            this.dtglancamentos.Name = "dtglancamentos";
            this.dtglancamentos.Size = new System.Drawing.Size(375, 128);
            this.dtglancamentos.TabIndex = 17;
            this.dtglancamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglancamentos_CellContentClick);
            // 
            // txtdata
            // 
            this.txtdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdata.Location = new System.Drawing.Point(288, 84);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(89, 20);
            this.txtdata.TabIndex = 18;
            // 
            // frmLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 327);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.dtglancamentos);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.rdbentrada);
            this.Controls.Add(this.rdbsaida);
            this.Controls.Add(this.cmbconta);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLancamento";
            this.Text = "frmLancamento";
            this.Load += new System.EventHandler(this.frmLancamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglancamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ComboBox cmbconta;
        private System.Windows.Forms.RadioButton rdbsaida;
        private System.Windows.Forms.RadioButton rdbentrada;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.DataGridView dtglancamentos;
        private System.Windows.Forms.DateTimePicker txtdata;
    }
}