using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDeDados;
using CamadaDeNegocios;

namespace ProjetoFluxoDeCaixa3C28
{
    public partial class frmconsultaporconta : Form
    {
        public frmconsultaporconta()
        {
            InitializeComponent();
        }
        LancamentoBLL obj = new LancamentoBLL();
        ContaBLL objConta = new ContaBLL();

        private void CarregarContas()
        {
            cmbocnta.DataSource = objConta.ListarContas("SELECT * FROM tbl_contas ORDER BY descricao;");
            cmbocnta.DisplayMember = "descricao";
            cmbocnta.ValueMember = "idConta";
            cmbocnta.SelectedIndex = -1;
        }
        private void dtgcontas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmconsultaporconta_Load(object sender, EventArgs e)
        {
            CarregarContas();

        }

        private void cmbocnta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtgcontas.DataSource = obj.ListarLancamentos("SELECT * FROM tbl_lancamentos WHERE idConta =" + cmbocnta.SelectedValue);
            txttotal.Text = obj.ObterSaldo("SELECT SUM(valor) FROM tbl_lancamentos WHERE idConta =" + cmbocnta.SelectedValue).ToString();
        }
    }
}
