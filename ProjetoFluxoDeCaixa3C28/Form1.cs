using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFluxoDeCaixa3C28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmContas Contas = new frmContas();
            Contas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLancamento Lancamento = new frmLancamento();
            Lancamento.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsaldo_Click(object sender, EventArgs e)
        {
            frmSaldo Saldo = new frmSaldo();
            Saldo.Show();
        }

        private void btnlancamentoss_Click(object sender, EventArgs e)
        {
            frmConsultaLancamentos CS = new frmConsultaLancamentos();
            CS.Show();
        }

        private void btnconsultaconta_Click(object sender, EventArgs e)
        {
            frmconsultaporconta CN = new frmconsultaporconta();
            CN.Show();
        }

        private void relatorioPorLancamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioLancamentos RL = new frmRelatorioLancamentos();
            RL.Show();
        }
    }
}