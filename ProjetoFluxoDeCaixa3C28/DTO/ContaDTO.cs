using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeTransferenciaDeDados
{
    public class ContaDTO
    {
        private int idConta;
        private string descricao;
        

        public int IdConta
        {
            get
            {
                return idConta;
            }

            set
            {
                idConta = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                if (Descricao == " ")
                {
                    throw new Exception("Selecione uma descrição");
                }
                else
                {
                    descricao = value;
                }

            }

        } 
    }
}
