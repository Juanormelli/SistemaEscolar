//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_Integrado
{
    using System;
    using System.Collections.Generic;
    
    public partial class responsaveis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public responsaveis()
        {
            this.aluno = new HashSet<aluno>();
        }
    
        public int cod_responsavel { get; set; }
        public string nome_resposavel { get; set; }
        public string email_responsavel { get; set; }
        public string telefone_responsavel { get; set; }
        public string cpf_resposnavel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aluno> aluno { get; set; }


    }
}