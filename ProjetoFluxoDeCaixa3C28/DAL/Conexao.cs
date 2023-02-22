using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CamadaDeDados
{
    public class Conexao
    {
        private string string_conexao = "Persist Security Info = false; server = localhost; database = db_fluxodecaixa; uid=root; pwd=;";
        public MySqlConnection conexao;
        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException)
            {
                throw new Exception("A conexão não foi estabelecida.");
            }
        }
        public void ExecutarComandos(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                throw new Exception("Instrução não executada. Verifique!!");
            }

            finally
            {
                conexao.Close();
            }
        }
        public DataTable ExecutarConsulta(string query)
        {
            Conectar();
            try
            {
                DataTable dados = new DataTable();
                MySqlDataAdapter consulta = new MySqlDataAdapter(query, conexao);
                consulta.Fill(dados);
                return dados;
            }
            catch(Exception)
            {
                throw new Exception("Consulta não realizada.");
            }
            finally
            {
                conexao.Close();
            }
        }
       
       
        public double CalculaTotais(string sql)
        {
            Conectar();
            
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                string total = comando.ExecuteScalar().ToString();
            
            if (total == "")
            {
                return 0;
            }
            else
            {
                return (double)comando.ExecuteScalar();
            }
        }
    }
}
