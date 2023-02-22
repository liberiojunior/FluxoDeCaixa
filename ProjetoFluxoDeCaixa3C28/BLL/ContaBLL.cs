using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDeDados;
using System.Data;
using CamadaDeTransferenciaDeDados;

namespace CamadaDeNegocios
{
    public class ContaBLL
    {
       
        Conexao bd = new Conexao();
  

        public void InserirConta(ContaDTO objDTO)
        {
            try
            {
                string inserir = "INSERT INTO tbl_contas VALUES(NULL, '" + objDTO.Descricao + "');";
                bd.ExecutarComandos(inserir);
            }
            catch
            {
                throw new Exception("Usuário não inserido");
            }
            
        }
        public void AlterarConta(ContaDTO objDTO)
        {
            try
            {
                string alterar = "UPDATE tbl_contas SET descricao ='" + objDTO.Descricao + "'WHERE idconta=" + objDTO.IdConta + ";";
                bd.ExecutarComandos(alterar);
            }
            catch
            {
                throw new Exception("Dados não alterados");
            }
        }
        public void ExcluirConta(ContaDTO objDTO)
        {
            try
            {
                string excluir = "DELETE FROM tbl_contas WHERE idconta =" + objDTO.IdConta + ";";
                bd.ExecutarComandos(excluir);
            }
            catch
            {
                throw new Exception("Dados não excluidos");
            }
        }
        public DataTable ListarContas(string query)
        {
            try
            {
                DataTable contas = new DataTable();
                contas = bd.ExecutarConsulta(query);
                return contas;
            }
            catch
            {
                throw new Exception("Dados não excluidos");
            }
        }

    }
}