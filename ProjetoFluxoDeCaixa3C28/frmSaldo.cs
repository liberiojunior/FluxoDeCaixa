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
    public partial class frmSaldo : Form
    {
        public frmSaldo()
        {
            InitializeComponent();
        }
        LancamentoBLL objLancamentos = new LancamentoBLL();

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txtsaldoperiodo.Text = dtgsaldo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtsaldogeral.Text = dtgsaldo.Rows[e.RowIndex].Cells[1].Value.ToString();*/
        }
        /*private void CarregarSaldo()
        {
            dtgsaldo.DataSource = objLancamentos.ListarLancamentos("SELECT * FROM tbl_lancamentos");
        }*/
        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            dtgsaldo.DataSource = objLancamentos.ListarLancamentos("SELECT * FROM tbl_lancamentos WHERE dataLancamento BETWEEN '" + dtpInicial.Value.ToString("yyyy/MM/dd") + "' AND '" + dtpFinal.Value.ToString("yyyy/MM/dd") + "';");

            double receitas = objLancamentos.ObterSaldo("SELECT SUM(valor) FROM tbl_lancamentos WHERE entradaSaida = 'E' AND dataLancamento BETWEEN '" + dtpInicial.Value.ToString("yyyy/MM/dd") + "' AND '" + dtpFinal.Value.ToString("yyyy/MM/dd") + "';");

            double despesas = objLancamentos.ObterSaldo("SELECT SUM(valor) FROM tbl_lancamentos WHERE entradaSaida = 'S' AND dataLancamento BETWEEN '" + dtpInicial.Value.ToString("yyyy/MM/dd") + "' AND '" + dtpFinal.Value.ToString("yyyy/MM/dd") + "';");

            txtsaldoperiodo.Text = (receitas - despesas).ToString();
        }

        private void frmSaldo_Load(object sender, EventArgs e)
        {
            double receitas = objLancamentos.ObterSaldo("SELECT SUM(valor) FROM tbl_lancamentos WHERE entradaSaida = 'E';");
            double despesas = objLancamentos.ObterSaldo("SELECT SUM(valor) FROM tbl_lancamentos WHERE entradaSaida = 'S';");
            txtsaldogeral.Text = (receitas - despesas).ToString();
            dtgsaldo.DataSource = objLancamentos.ListarLancamentos("SELECT * FROM tbl_lancamentos;");
        }
    }
}