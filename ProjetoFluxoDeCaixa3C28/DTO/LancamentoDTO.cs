using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeTransferenciaDeDados
{
    public class LancamentoDTO
    {
        private int idLancamento;
        private string ddescricao;
        private int iddConta;
        private DateTime dataLancamento;
        private char entradaSaida;
        private double valor;

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public char EntradaSaida
        {
            get
            {
                return entradaSaida;
            }

            set
            {
                entradaSaida = value;
            }
        }

        public DateTime DataLancamento
        {
            get
            {
                return dataLancamento;
            }

            set
            {
                dataLancamento = value;
            }
        }

        public int IdLancamento
        {
            get
            {
                return idLancamento;
            }

            set
            {
                idLancamento = value;
            }
        }

        public string Descricao
        {
            get
            {
                return ddescricao;
            }

            set
            {
                ddescricao = value;
            }
        }

        public int IdConta
        {
            get
            {
                return iddConta;
            }

            set
            {
                iddConta = value;
            }
        }
    }
}
