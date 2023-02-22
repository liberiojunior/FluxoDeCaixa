using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CamadaDeDados;
using System.Data;

namespace CamadaDeLogin
{
    class UsuarioBLL
    {
        Conexao objDAL = new Conexao();

        public bool ValidarLogin(string uLogin,string uPassword)
        { 
            string sql = "SELECT * FROM tbl_usuario WHERE BINARY login ='" + uLogin + "' AND senha= '" + uPassword + "'";
            DataTable busca = objDAL.ExecutarConsulta(sql);
            if (busca.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            
    }
}
