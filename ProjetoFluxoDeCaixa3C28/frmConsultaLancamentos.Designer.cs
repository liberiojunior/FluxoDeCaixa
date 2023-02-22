namespace ProjetoFluxoDeCaixa3C28
{
    partial class frmConsultaLancamentos
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
            this.rdbentrada = new System.Windows.Forms.RadioButton();
            this.rdbsaida = new System.Windows.Forms.RadioButton();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.dtglancamentos = new System.Windows.Forms.DataGridView();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.lblsaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtglancamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbentrada
            // 
            this.rdbentrada.AutoSize = true;
            this.rdbentrada.Location = new System.Drawing.Point(12, 12);
            this.rdbentrada.Name = "rdbentrada";
            this.rdbentrada.Size = new System.Drawing.Size(62, 17);
            this.rdbentrada.TabIndex = 0;
            this.rdbentrada.TabStop = true;
            this.rdbentrada.Text = "Entrada";
            this.rdbentrada.UseVisualStyleBackColor = true;
            // 
            // rdbsaida
            // 
            this.rdbsaida.AutoSize = true;
            this.rdbsaida.Location = new System.Drawing.Point(91, 12);
            this.rdbsaida.Name = "rdbsaida";
            this.rdbsaida.Size = new System.Drawing.Size(54, 17);
            this.rdbsaida.TabIndex = 1;
            this.rdbsaida.TabStop = true;
            this.rdbsaida.Text = "Saída";
            this.rdbsaida.UseVisualStyleBackColor = true;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(183, 12);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 34);
            this.btnpesquisar.TabIndex = 2;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // dtglancamentos
            // 
            this.dtglancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglancamentos.Location = new System.Drawing.Point(12, 52);
            this.dtglancamentos.Name = "dtglancamentos";
            this.dtglancamentos.Size = new System.Drawing.Size(274, 169);
            this.dtglancamentos.TabIndex = 3;
            this.dtglancamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglancamentos_CellContentClick);
            // 
            // txtsaldo
            // 
            this.txtsaldo.Location = new System.Drawing.Point(101, 251);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(100, 20);
            this.txtsaldo.TabIndex = 4;
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Location = new System.Drawing.Point(20, 254);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(64, 13);
            this.lblsaldo.TabIndex = 5;
            this.lblsaldo.Text = "Saldo Atual:";
            // 
            // frmConsultaLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 291);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.txtsaldo);
            this.Controls.Add(this.dtglancamentos);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.rdbsaida);
            this.Controls.Add(this.rdbentrada);
            this.Name = "frmConsultaLancamentos";
            this.Text = "frmConsultaLancamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dtglancamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbentrada;
        private System.Windows.Forms.RadioButton rdbsaida;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DataGridView dtglancamentos;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.Label lblsaldo;
    }
}