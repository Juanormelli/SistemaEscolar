using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Integrado
{
    class Responsavel
    {
        public string Nome_Pai{ get; set; }
        public string Nome_Mae { get; set; }
        public long Telefone_Pai {get; set; }
        public long Telefone_Mae { get; set; }
        public string Email_Pai { get; set; }
        public string Email_Mae { get; set; }

        public string Cpf_Pai { get; set; }
        public string Cpf_Mae { get; set; }

        public void Cadastrar_Resp(Responsavel responsavel)
        {
            var con = new Conexao();
            con.Cadastrar_Responsaveis(responsavel);

        }

    }
}
