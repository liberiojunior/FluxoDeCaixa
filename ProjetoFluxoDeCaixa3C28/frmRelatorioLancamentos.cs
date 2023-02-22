using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDeNegocios;

namespace ProjetoFluxoDeCaixa3C28
{
    public partial class frmRelatorioLancamentos : Form
    {
        public frmRelatorioLancamentos()
        {
            InitializeComponent();
        }
        LancamentoBLL objLBB = new LancamentoBLL();
        private void ExibirDados()
        {
            dtg.DataSource = objLBB.ListarLancamentos(
                "SELECT tbl_contas.descricao 'Conta', SUM(valor) 'Total R$' FROM tbl_lancamentos INNER JOIN tbl_contas ON tbl_lancamentos.idConta = tbl_Contas.idConta GROUP BY tbl_Contas.descricao;");
        }

        private void frmRelatorioLancamentos_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }
    }
}
