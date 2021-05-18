using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrado
{
    class FunctionsAluno
    {
        public bool ValidaAluno(aluno aluno)
        {
            using (var context = new gestaoescolarEntities())
            {
                var valida = context.aluno.Where(x => x.cpf == aluno.cpf);

                var count = valida.Count();
                if (count != 0)
                {
                    return false;
                }
                return true;
            }
        }
        public void CadastrarAluno(aluno aluno)
        {
            using (var context = new gestaoescolarEntities())
            {

                context.aluno.Add(aluno);

                context.SaveChanges();

            }

        }
        public void CadastrarRespAluno(aluno aluno, responsaveis responsaveis)
        {
            using (var context = new gestaoescolarEntities())
            {

                aluno.responsaveis.Add(responsaveis);
                context.SaveChanges();

            }

        }
        public string RetornarMatricula(aluno al)
        {
            using (var context = new gestaoescolarEntities())
            {
                var alunos = context.aluno.Select(x => new { x.numero_matricula, x.cpf }).Where(x => x.cpf == al.cpf).ToList();

                var str = alunos[0].numero_matricula.ToString();
                return str;
            }


        }

    }
}
