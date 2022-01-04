using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackedinSite.Models
{
    public class Vaga
    {
       [Key]
        public int VagaId { get; set; }

        public String Nome { get; set; }

        public String CNPJ { get; set; }

        public String Email { get; set; }

        public String RazaoSocial { get; set; }

        public String Senha { get; set; }
    }
}
