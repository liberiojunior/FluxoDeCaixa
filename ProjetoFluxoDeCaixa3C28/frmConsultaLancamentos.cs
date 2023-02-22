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
    public partial class frmConsultaLancamentos : Form
    {
        public frmConsultaLancamentos()
        {
            InitializeComponent();
        }

        LancamentoBLL obj = new LancamentoBLL();

        private void dtglancamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rdbentrada.Checked = (dtglancamentos.Rows[e.RowIndex].Cells[0].Value.ToString() == "E" ? true : false);
            rdbsaida.Checked = (dtglancamentos.Rows[e.RowIndex].Cells[0].Value.ToString() == "S" ? true : false);
        }

        private void CarregarGridExibir()
        {
            dtglancamentos.DataSource = obj.ListarLancamentos("SELECT * FROM tbl_lancamentos ORDER BY descricao;");
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if(rdbentrada.Checked)
            {
                dtglancamentos.DataSource = obj.ListarLancamentos("SELECT * FROM tbl_lancamentos WHERE entradaSaida = 'E';");
                txtsaldo.Text = obj.ObterSaldo("SELECT SUM(valor) FROM tbl_lancamentos WHERE entradaSaida = 'E'").ToString();
            }
            else
            {
                dtglancamentos.DataSource = obj.ListarLancamentos("SELECT * FROM tbl_lancamentos WHERE entradaSaida = 'S';");
                txtsaldo.Text = obj.ObterSaldo("SELECT SUM(valor) FROM tbl_lancamentos WHERE entradaSaida = 'S'").ToString();
            }
        }
    }
}
