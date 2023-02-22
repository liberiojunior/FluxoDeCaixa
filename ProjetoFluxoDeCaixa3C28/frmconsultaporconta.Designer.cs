namespace ProjetoFluxoDeCaixa3C28
{
    partial class frmconsultaporconta
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
            this.lblconta = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.cmbocnta = new System.Windows.Forms.ComboBox();
            this.dtgcontas = new System.Windows.Forms.DataGridView();
            this.txttotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcontas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblconta
            // 
            this.lblconta.AutoSize = true;
            this.lblconta.Location = new System.Drawing.Point(12, 9);
            this.lblconta.Name = "lblconta";
            this.lblconta.Size = new System.Drawing.Size(35, 13);
            this.lblconta.TabIndex = 0;
            this.lblconta.Text = "Conta";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(12, 217);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "Total";
            // 
            // cmbocnta
            // 
            this.cmbocnta.FormattingEnabled = true;
            this.cmbocnta.Location = new System.Drawing.Point(76, 6);
            this.cmbocnta.Name = "cmbocnta";
            this.cmbocnta.Size = new System.Drawing.Size(121, 21);
            this.cmbocnta.TabIndex = 2;
            this.cmbocnta.SelectionChangeCommitted += new System.EventHandler(this.cmbocnta_SelectionChangeCommitted);
            // 
            // dtgcontas
            // 
            this.dtgcontas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcontas.Location = new System.Drawing.Point(15, 47);
            this.dtgcontas.Name = "dtgcontas";
            this.dtgcontas.Size = new System.Drawing.Size(240, 150);
            this.dtgcontas.TabIndex = 3;
            this.dtgcontas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgcontas_CellContentClick);
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(76, 214);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 4;
            // 
            // frmconsultaporconta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 261);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dtgcontas);
            this.Controls.Add(this.cmbocnta);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblconta);
            this.Name = "frmconsultaporconta";
            this.Text = "frmconsultaporconta";
            this.Load += new System.EventHandler(this.frmconsultaporconta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgcontas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconta;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.ComboBox cmbocnta;
        private System.Windows.Forms.DataGridView dtgcontas;
        private System.Windows.Forms.TextBox txttotal;
    }
}