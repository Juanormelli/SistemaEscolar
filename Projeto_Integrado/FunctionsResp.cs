using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrado
{
    class FunctionsResp
    {
        public bool ValidaResponsavel(responsaveis responsaveis)
        {
            using (var context = new gestaoescolarEntities())
            {
                var valida = context.responsaveis.Where(x => x.cpf_resposnavel == responsaveis.cpf_resposnavel);

                var count = valida.Count();
                if (count != 0)
                {
                    return false;
                }
                return true;
            }
        }
        public void CadastrarResponsavel(responsaveis responsaveis)
        {
            using (var context = new gestaoescolarEntities())
            {

                context.responsaveis.Add(responsaveis);
                context.SaveChanges();

            }

        }
    }
}
