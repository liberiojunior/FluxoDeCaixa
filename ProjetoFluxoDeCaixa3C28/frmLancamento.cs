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
using CamadaDeDados;
using CamadaDeTransferenciaDeDados;

namespace ProjetoFluxoDeCaixa3C28
{
    public partial class frmLancamento : Form
    {
        public frmLancamento()
        {
            InitializeComponent();
        }
        LancamentoBLL objLancamento = new LancamentoBLL();
        ContaBLL objConta = new ContaBLL();
        ContaDTO objDTO = new ContaDTO();
        LancamentoDTO objLDTO = new LancamentoDTO();

        private void CarregarContas()
        {
            cmbconta.DataSource = objConta.ListarContas("SELECT * FROM tbl_contas ORDER BY descricao;");
            cmbconta.DisplayMember = "descricao";
            cmbconta.ValueMember = "idConta";
        }
        private void CarregarGridLancamentos()
        {
            dtglancamentos.DataSource = objLancamento.ListarLancamentos("SELECT * FROM tbl_lancamentos ORDER BY idLancamento;");
        }

        

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Limpar()
        {
            txtcodigo.Clear();
            txtdata.Text = "";
            txtdescricao.Clear();
            txtvalor.Clear();
            cmbconta.Text = "";
            rdbentrada.Checked = false;
            rdbsaida.Checked = false;
            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();

        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                objLDTO.Descricao = txtdescricao.Text;
                objLDTO.DataLancamento = txtdata.Value;
                objLDTO.Valor = double.Parse(txtvalor.Text);
                objLDTO.EntradaSaida = rdbentrada.Checked ? 'E' : rdbsaida.Checked ? 'S' : ' ';
                objLDTO.IdConta = int.Parse(cmbconta.SelectedValue.ToString());
                
                

                if (txtcodigo.Text == "")
                {
                    objLancamento.InserirLancamento(objLDTO);
                    MessageBox.Show("Dados inseridos com sucesso!");
                    
                }
                else
                {
                    objLDTO.IdConta = int.Parse(txtcodigo.Text);
                    objLancamento.AlterarLancamento(objLDTO);
                }
                CarregarGridLancamentos();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtglancamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dtglancamentos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtdescricao.Text = dtglancamentos.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbconta.Text = dtglancamentos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdata.Text = dtglancamentos.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dtglancamentos.Rows[e.RowIndex].Cells[4].Value.ToString() == "E")
            {
                rdbentrada.Checked = true;
            }
            else if(dtglancamentos.Rows[e.RowIndex].Cells[4].Value.ToString() == "S")
            {
                rdbsaida.Checked = true;
            }
            else
            {
                rdbentrada.Checked = false;
                rdbsaida.Checked = false;
            }
            
            
            txtvalor.Text = dtglancamentos.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void frmLancamento_Load(object sender, EventArgs e)
        {
            CarregarContas();
            CarregarGridLancamentos();
        }


        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            objLDTO.IdLancamento = int.Parse(txtcodigo.Text);
            objLancamento.ExcluirLancamento(objLDTO);
            MessageBox.Show("Dados excluidos com sucesso!");
            CarregarGridLancamentos();
        }
    }
}

