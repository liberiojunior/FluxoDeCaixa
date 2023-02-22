using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDeLogin;
namespace ProjetoFluxoDeCaixa3C28
{
    public partial class frmLogin2 : Form
    {
        public frmLogin2()
        {
            InitializeComponent();
        }
        UsuarioBLL obj = new UsuarioBLL();


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconfirmar_Click_1(object sender, EventArgs e)
        {
            if (obj.ValidarLogin(txtusuario.Text, txtsenha.Text)==true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Dados Incorretos!");
            }
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
