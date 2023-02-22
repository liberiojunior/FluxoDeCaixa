using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDeDados;
using CamadaDeNegocios;
using CamadaDeTransferenciaDeDados;

namespace CamadaDeNegocios
{
    class LancamentoBLL
    {
        Conexao bd = new Conexao();
       

        public void InserirLancamento(LancamentoDTO objLDTO)
        {
            try
            {
                string inserir = "INSERT INTO tbl_lancamentos VALUES(NULL, '" + objLDTO.Descricao + "','" + objLDTO.IdConta + "' , '" + objLDTO.DataLancamento.ToString("yyyy/MM/dd") + "', '" + objLDTO.EntradaSaida + "'  , '" + objLDTO.Valor + "'); ";
                bd.ExecutarComandos(inserir);
            }
            catch
            {
                throw new Exception("Instrução não executada. Verifique!!");
            }
        }
        public void AlterarLancamento(LancamentoDTO objLDTO)
        { 
            try
            {
                string alterar = "UPDATE tbl_lancamentos SET descricao ='" + objLDTO.Descricao + "'WHERE idconta=" + objLDTO.IdLancamento + ";";
                bd.ExecutarComandos(alterar);
            }
            catch
            {
                throw new Exception("Instrução não executada. Verifique!!");
            }
        }
        public void ExcluirLancamento(LancamentoDTO objLDTO)
        {
            try
            {
                string excluir = "DELETE FROM tbl_lancamentos WHERE idLancamento =" + objLDTO.IdLancamento + ";";
                bd.ExecutarComandos(excluir);
            }
            catch
            {
                throw new Exception("Instrução não executada. Verifique!!");
            }
        }
        public DataTable ListarLancamentos(string query)
        {
            try
            {
                DataTable contas = new DataTable();
                contas = bd.ExecutarConsulta(query);
                return contas;
            }
            catch
            {
                throw new Exception("Instrução não executada. Verifique!!");
            }
        }
        public double ObterSaldo(string query)
        {
            try
            {
                return bd.CalculaTotais(query);
            }
            catch
            {
                throw new Exception("Instrução não executada. Verifique!!");
            }
        }

    }
}