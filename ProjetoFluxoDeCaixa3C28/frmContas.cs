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
using CamadaDeTransferenciaDeDados;

namespace ProjetoFluxoDeCaixa3C28
{
    public partial class frmContas : Form
    {
        public frmContas()
        {
            InitializeComponent();
        }
        ContaBLL objContas = new ContaBLL();
        ContaDTO objDTO = new ContaDTO();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarregarGridContas()
        {
            dtgcontas.DataSource = objContas.ListarContas("SELECT * FROM tbl_contas ORDER BY descricao;");
        }
        private void Limpar()
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            objDTO.Descricao = txtdescricao.Text;

            if(txtcodigo.Text=="")
            {
                objContas.InserirConta(objDTO);
            }
            else
            {
                objDTO.IdConta = int.Parse(txtcodigo.Text);
                objContas.AlterarConta(objDTO);
            }
            CarregarGridContas();
            MessageBox.Show("Dados cadastrados!!");
            Limpar();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgcontas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dtgcontas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtdescricao.Text = dtgcontas.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void frmContas_Load(object sender, EventArgs e)
        {
            CarregarGridContas();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            objDTO.IdConta = int.Parse(txtcodigo.Text);
            objContas.ExcluirConta(objDTO);
            CarregarGridContas();
        }
    }
}
